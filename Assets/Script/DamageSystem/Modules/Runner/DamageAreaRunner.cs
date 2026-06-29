using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UnityEngine;

public class DamageAreaRunner : MonoBehaviour
{
    public DamageAreaData DamageAreaData { get; private set; }

    private readonly Subject<DamageAreaStateChanged> _stateChanged = new();

    public IObservable<DamageAreaStateChanged> OnStateChanged => _stateChanged;

    public void Initialize(DamageAreaData data)
    {
        DamageAreaData = data;
    }

    public async UniTask Run()
    {
        ChangeState(DamageAreaState.FadeIn);
        await UniTask.Delay((int)(DamageAreaData.TimeData.FadeInTime * 1000));

        ChangeState(DamageAreaState.Attack);
        await UniTask.Delay((int)(DamageAreaData.TimeData.AttackTime * 1000));

        ChangeState(DamageAreaState.FadeOut);
        await UniTask.Delay((int)(DamageAreaData.TimeData.FadeOutTime * 1000));

        ChangeState(DamageAreaState.Released);
    }

    private void ChangeState(DamageAreaState state) 
    {
        _stateChanged.OnNext(new DamageAreaStateChanged(state, DamageAreaData));
    }
}