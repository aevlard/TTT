using System;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    
    
    //[SerializeField] GameObject laserPrefab;
    [SerializeField] WeaponBase currentWeapon;
    
    // public void PerformShoot()
    // {
    //     GameObject laser = Instantiate(laserPrefab, transform.position, transform.rotation);
    //     
    //     Vector2 direction = transform.up;
    //     laser.GetComponent<Rigidbody2D>().linearVelocity = direction * 10;
    //     
    //     Destroy(laser, 10f);
    // }

    private void Start()
    {
        currentWeapon.SetPlayerTransform(transform);
    }

    public void PerformShoot()
    {
        currentWeapon.Shoot();
    }
}
