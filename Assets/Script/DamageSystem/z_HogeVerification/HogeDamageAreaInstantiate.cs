using System;
using UnityEngine;

/// <summary>
/// GCがどの程度ラグに影響するか気になった為
/// あえて毎回生成する
/// </summary>
public class HogeDamageAreaInstantiate : MonoBehaviour
{
    [SerializeField] GameObject _prefabCircle;
    [SerializeField] GameObject _prefabRect;

    public DamageAreaRunner Instantiate(DamageAreaData data)
    {
        DamageAreaRunner runner;
        return data.ShapeData switch
        {
            DamageAreaCircleData => runner
            = Instantiate(_prefabCircle).GetComponent<DamageAreaRunner>(),

            DamageAreaRectData => runner
            = Instantiate(_prefabRect).GetComponent<DamageAreaRunner>(),

            _ => throw new NotSupportedException()
        };
    }

    private void Hoge()
    {

    }
}
