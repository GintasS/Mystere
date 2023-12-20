using UnityEngine;

/// <summary>
/// Class that handles player ability to deal damage to other objects.
/// </summary>
public sealed class PlayerAttack : MonoBehaviour
{
    [Header("Raycast Settings")]
    [SerializeField]
    private new Camera camera;
    [Header("Script References")]
    [SerializeField]
    private PlayerWeaponEquipHandler playerWeaponEquipHandler;

    private PlayerWeapon EquipedWeapon
    {
        get
        {
            return playerWeaponEquipHandler.EquipedWeapon;
        }
    }


    /// <summary>
    /// <summary>
    /// Attack a zombie GameObject via shooting a raycast and checking if it hit a zombie.
    /// </summary>
    public void AttackWithWeapon()
    {
        if (EquipedWeapon.IsUtilityWeapon is true)
        {
            return;
        }

        var attackRange = EquipedWeapon.WeaponAttackRange;
        var raycastHit = ShootRaycast(attackRange);
        var hitCollider = raycastHit.collider;

        if (hitCollider != null && hitCollider.IsZombieCollider() && EquipedWeapon.WeaponAmmo.HasAmmo)
        {
            var damage = RandomNumberGenerator.Generate(EquipedWeapon.WeaponAttackStrength);
            var health = raycastHit.collider.transform.GetComponent<ZombieHealth>();
            health.TryTakeDamage(damage);  

        }

        playerWeaponEquipHandler.EquipedWeapon.WeaponAmmo.ReduceCurrentAmmoByOne();
    }

    /// <summary>
    /// Shoots a raycast. 
    /// </summary>
    /// <returns>RacaystHit instance</returns>
    private RaycastHit ShootRaycast(PlayerWeaponAttackRange playerWeapon)
    {
        var rayOrigin = camera.ViewportToWorldPoint(Constants.Camera.Center);
        Physics.Raycast(rayOrigin, camera.transform.forward, out var hit, playerWeapon.AttackRange);

        return hit;
    }
}