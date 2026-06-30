using UnityEngine;

public class DamageAreaSpwaner : MonoBehaviour
{
    private readonly DamageAreaInitializer _factory;

    public DamageAreaSpwaner(DamageAreaInitializer factory)
    {
        _factory = factory;
    }

    public void SpawnDamageArea(DamageAreaData areaData)
    {
        
    }
}
