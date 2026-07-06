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

    public DamageAreaRoot Instantiate(DamageAreaShapeBaseData data)
    {
        DamageAreaRoot root;
        return data switch
        {
            DamageAreaCircleData => root
            = Instantiate(_prefabCircle).GetComponent<DamageAreaRoot>(),

            DamageAreaRectData => root
            = Instantiate(_prefabRect).GetComponent<DamageAreaRoot>(),

            _ => throw new NotSupportedException()
        };
    }
}
