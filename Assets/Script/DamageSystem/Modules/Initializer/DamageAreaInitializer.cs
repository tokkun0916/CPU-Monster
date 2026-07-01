using UnityEngine;

public class DamageAreaInitializer : MonoBehaviour
{
    private readonly HogeDamageAreaInstantiate _hogeDamageAreaInstantiate;

    public DamageAreaInitializer(HogeDamageAreaInstantiate hogeDamageAreaInstantiate)
    {
        _hogeDamageAreaInstantiate = hogeDamageAreaInstantiate;
    }

    public void DamageAreaInitialize(DamageAreaData areaData)
    {
        DamageAreaRunner runner = _hogeDamageAreaInstantiate.Instantiate(areaData.ShapeData);
        runner.Initialize(areaData);
        runner.Run();
    }
}
