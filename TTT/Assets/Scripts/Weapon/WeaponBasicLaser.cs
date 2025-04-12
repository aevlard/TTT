using UnityEngine;

public class WeaponBasicLaser : WeaponBase
{
    public override void OnMeteoreHit(MeteorBase _meteoreBase)
    {
        base.OnMeteoreHit(_meteoreBase);
        _meteoreBase.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
