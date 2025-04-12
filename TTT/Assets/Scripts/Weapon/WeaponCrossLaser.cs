using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponCrossLaser : WeaponBase
{
    public override void OnMeteoreHit(MeteorBase _meteoreBase)
    {
        base.OnMeteoreHit(_meteoreBase);

        float currentSpeed = _meteoreBase.GetComponent<MeteorMovement>().speed;
        _meteoreBase.GetComponent<MeteorMovement>().speed = currentSpeed / 2;
    }
}
