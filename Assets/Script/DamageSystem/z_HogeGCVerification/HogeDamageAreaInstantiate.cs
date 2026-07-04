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

    public GameObject Instantiate(DamageAreaShapeBaseData data)
    {
        GameObject runner;
        return data switch
        {
            DamageAreaCircleData => runner
            = Instantiate(_prefabCircle),

            DamageAreaRectData => runner
            = Instantiate(_prefabRect),

            _ => throw new NotSupportedException()
        };
    }
}
