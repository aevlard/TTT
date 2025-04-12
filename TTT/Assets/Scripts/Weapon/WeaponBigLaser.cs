using UnityEngine;

public class WeaponBigLaser : WeaponBase
{
    public override void OnMeteoreHit(MeteorBase _meteoreBase)
    {
        base.OnMeteoreHit(_meteoreBase);

        Vector3 currentScale = _meteoreBase.GetComponent<Transform>().localScale;
        
        _meteoreBase.GetComponent<Transform>().localScale = currentScale / 2f;
    }

}
