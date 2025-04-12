using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionDetector : MonoBehaviour
{
    private WeaponBase _weaponBase;
    private void Awake()
    {
        _weaponBase = GetComponent<WeaponBase>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _weaponBase.OnMeteoreHit(other.gameObject.GetComponent<MeteorBase>());
        Debug.Log(other.gameObject.name);
    }
}
