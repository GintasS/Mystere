using UnityEngine;

/// <summary>
/// Class that holds a single weapon.
/// </summary>
public sealed class PlayerWeapon : MonoBehaviour
{
    [Header("Weapon Main Settings")]
    [SerializeField]
    private GameObject weaponObject;
    [Header("Weapon Attack Strength Settings")]
    [SerializeField]
    private PlayerWeaponAttackStrength playerWeaponAttackStrength;
    [Header("Weapon Ammo Settings")]
    [SerializeField]
    private PlayerWeaponAmmo playerWeaponAmmo;
    [Header("Weapon Shoot Settings")]
    [SerializeField]
    private PlayerWeaponShoot playerWeaponShoot;
    [Header("Weapon Sound Settings")]
    [SerializeField]
    private PlayerWeaponSoundsHandler playerWeaponSoundsHandler;
    [Header("Weapon Animation Settings")]
    [SerializeField]
    private PlayerWeaponAnimation playerWeaponAnimation;
    [Header("Weapon Flashlight Settings")]
    [SerializeField]
    private PlayerWeaponFlashlight playerWeaponFlashlight;
    [Header("Weapon Attack Range Settings")]
    [SerializeField]
    private PlayerWeaponAttackRange playerWeaponAttackRange;
    [Header("Weapon States")]
    [SerializeField]
    private bool isUtilityWeapon;
    [SerializeField]
    private bool isHandWeapon;


    /// <summary>
    /// Get player weapon ammo instance for this weapon.
    /// </summary>
    public PlayerWeaponAmmo WeaponAmmo
    {
        get
        {
            return playerWeaponAmmo;
        }
    }

    /// <summary>
    /// Get player weapon shoot instance for this weapon.
    /// </summary>
    public PlayerWeaponShoot WeaponShoot
    {
        get
        {
            return playerWeaponShoot;
        }
    }

    /// <summary>
    /// Get player weapon sounds instance for this weapon.
    /// </summary>
    public PlayerWeaponSoundsHandler WeaponSoundsHandler
    {
        get
        {
            return playerWeaponSoundsHandler;
        }
    }

    /// <summary>
    /// Get player weapon animation instance for this weapon.
    /// </summary>
    public PlayerWeaponAnimation WeaponAnimation
    {
        get
        {
            return playerWeaponAnimation;
        }
    }

    /// <summary>
    /// Get player weapon attack strength instance for this weapon.
    /// </summary>
    public PlayerWeaponAttackStrength WeaponAttackStrength
    {
        get
        {
            return playerWeaponAttackStrength;
        }
    }

    /// <summary>
    /// Get player weapon flashlight instance for this weapon.
    /// </summary>
    public PlayerWeaponFlashlight WeaponFlashlight
    {
        get
        {
            return playerWeaponFlashlight;
        }
    }

    /// <summary>
    /// Get player weapon flashlight instance for this weapon.
    /// </summary>
    public PlayerWeaponAttackRange WeaponAttackRange
    {
        get
        {
            return playerWeaponAttackRange;
        }
    }

    /// <summary>
    /// Check if player's weapon is just an utility.
    /// </summary>
    public bool IsUtilityWeapon
    {
        get
        {
            return isUtilityWeapon;
        }
    }

    /// <summary>
    /// Check if player's weapon is just an hand weapon.
    /// </summary>
    public bool IsHandWeapon
    {
        get
        {
            return isHandWeapon;
        }
    }

    /// <summary>
    /// ActivatesDeactivates weapon object, based on the value passed.
    /// </summary>
    /// <param name="value">State value: false to deactivate, true to activate.</param>
    public void SetWeaponObjectActive(bool value)
    {
        weaponObject.SetActive(value);
    }
}