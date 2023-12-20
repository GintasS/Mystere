using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterFlying : MonoBehaviour
{
    [Header("Waypoints to patrol")]
    [SerializeField]
    public Transform[] waypoints;
    [SerializeField]
    private int destIndex = 0;
    [Header("Time range to sit in one waypoint")]
    [SerializeField]
    private float minTimeToIdleInWaypoint;
    [SerializeField]
    private float maxTimeToIdleInWaypoint;

    [Header("Generated values for idling")]
    [SerializeField]
    private float currentTimerInWaypoint;
    [SerializeField]
    private float generatedDefaultTimerInWaypoint;

    [Header("Time to rotate")]
    [SerializeField]
    private float currentTimeToRotate = 0;
    [SerializeField]
    private float defaultTimeToRotate = 10f;

    private bool reachedWaypoint;

    void Start()
    {
        generatedDefaultTimerInWaypoint = RandomNumberGenerator.Generate(minTimeToIdleInWaypoint, maxTimeToIdleInWaypoint);
        currentTimeToRotate = defaultTimeToRotate;
        StartCoroutine(RotateToTarget(waypoints[0]));
    }

    IEnumerator WalkWaypoint(Transform waypoint)
    {
        while ((transform.position - waypoint.position).sqrMagnitude > 0.001f)
        {
            transform.position = Vector3.MoveTowards(
                        transform.position,
                        waypoint.position,
                        5 * Time.deltaTime
            );

            yield return null;
        }

        reachedWaypoint = true;
        currentTimerInWaypoint = generatedDefaultTimerInWaypoint;
    }

    IEnumerator RotateToTarget(Transform target)
    {
        while (currentTimeToRotate > 0)
        {
            Vector3 dir = target.position - transform.position;
            var rotation = Quaternion.LookRotation(dir);
            var lerpValue = Quaternion.Lerp(transform.rotation, rotation, 3 * Time.deltaTime);

            transform.rotation = lerpValue;

            currentTimeToRotate -= Time.deltaTime;
            yield return null;
        }

        StartCoroutine(WalkWaypoint(waypoints[destIndex]));
    }

    void Update()
    {
        if (currentTimerInWaypoint > 0)
        {
            currentTimerInWaypoint -= Time.deltaTime;
        }

        if (reachedWaypoint && currentTimerInWaypoint <= 0)
        {
            currentTimeToRotate = defaultTimeToRotate;
            if (destIndex + 1 < waypoints.Length)
            {
                reachedWaypoint = false;
                destIndex++;
                StartCoroutine(RotateToTarget(waypoints[destIndex]));
            }
            else if (destIndex + 1 == waypoints.Length)
            {
                reachedWaypoint = false;
                destIndex = 0;
                StartCoroutine(RotateToTarget(waypoints[destIndex]));
            }
        }
    }

}
