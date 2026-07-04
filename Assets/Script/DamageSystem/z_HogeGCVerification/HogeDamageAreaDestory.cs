using UnityEngine;
using UniRx;

/// <summary>
/// GCがどの程度ラグに影響するか気になった為
/// あえて毎回削除する
/// </summary>
public class HogeDamageAreaDestory : MonoBehaviour
{
    public void Initialize(DamageAreaRunner runner)
    {
        runner.OnStateChanged
            .Subscribe(state =>
            {
                switch (state._State)
                {
                    case DamageAreaState.Released:
                        Destroy(runner.gameObject);
                        break;
                }
            });
    }
}
