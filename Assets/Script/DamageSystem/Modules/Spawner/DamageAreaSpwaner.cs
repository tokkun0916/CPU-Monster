using UnityEngine;

/// <summary>
/// ダメージエリアを生成したいと要求する中継クラス
/// 今後、生成条件等が増えた場合にここで制御することを想定している
/// </summary>
public class DamageAreaSpwaner : MonoBehaviour
{
    private DamageAreaFactory _factory;

    public void Initialize(DamageAreaFactory initializer)
    {
        _factory = initializer;
    }

    public void Spawn(DamageAreaData areaData)
    {
        _factory.Create(areaData);
    }
}
