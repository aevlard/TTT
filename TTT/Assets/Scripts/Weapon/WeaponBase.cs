using System;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    
    [SerializeField] float projectileSpeed = 0.5f;
    [SerializeField] int damage = 10;
    
    private Transform playerTransform;


    public void SetPlayerTransform(Transform _playerTransform)
    {
        playerTransform = _playerTransform;
    }
    public void Shoot()
    {
        GameObject projectile = Instantiate(this.gameObject, playerTransform.position, playerTransform.rotation);
        Destroy(projectile, 10f);
        AddProjectileForce(projectile);
    }

    private void AddProjectileForce(GameObject projectile)
    {
        Vector2 direction = playerTransform.up;
        projectile.GetComponent<Rigidbody2D>().linearVelocity = direction * projectileSpeed;
    }

    private void MakeDamage(MeteorBase _meteoreBase)
    {
        _meteoreBase.TakeDamage(damage);
    }

    public virtual void OnMeteoreHit(MeteorBase _meteoreBase)
    {
        MakeDamage(_meteoreBase);
    }
}
