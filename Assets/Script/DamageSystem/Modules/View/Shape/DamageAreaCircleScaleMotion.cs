using DG.Tweening;
using UnityEngine;
using UniRx;


public class DamageAreaCircleScaleMotion : DamageAreaScaleMotion
{
    private DamageAreaCircleData _circleData;

    private void Awake()
    {
        Runner = GetComponent<DamageAreaRunner>();

        Runner.OnStateChanged
            .Subscribe(OnStateChanged)
            .AddTo(this);
    }

    public override void Initialize(DamageAreaData areaData)
    {
        TimeData = areaData.TimeData;
        _circleData = (DamageAreaCircleData)areaData.ShapeData;
    }

    private void OnStateChanged(DamageAreaStateChanged changedData)
    {
        switch (changedData.State)
        {
            case DamageAreaState.Spawn:
                {
                    // 指定された位置に配置し、スケールを0にしてからアニメーションで拡大する
                    transform.localPosition = _circleData.CenterPosition;
                    transform.localScale = Vector3.zero;
                    transform
                        .DOScale(_circleData.Radius, TimeData.SpawnTime)
                        .SetEase(Ease.OutSine);
                }
                break;
            case DamageAreaState.FadeOut:
                {
                    transform
                        .DOScale(0f, TimeData.FadeOutTime)
                        .SetEase(Ease.OutSine);
                }
                break;
        }
    }

    public override void ResetObject()
    {
        _circleData = null;
    }
}
