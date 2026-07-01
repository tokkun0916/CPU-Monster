using UnityEngine;

public class DamageAreaSpwaner : MonoBehaviour
{
    private readonly DamageAreaInitializer _initializer;

    public DamageAreaSpwaner(DamageAreaInitializer initializer)
    {
        _initializer = initializer;
    }

    public void SpawnDamageArea(DamageAreaData areaData)
    {
        _initializer.DamageAreaInitialize(areaData);
    }
}
