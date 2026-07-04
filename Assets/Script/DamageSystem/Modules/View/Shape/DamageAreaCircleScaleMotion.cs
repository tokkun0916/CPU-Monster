using DG.Tweening;
using UnityEngine;
using UniRx;


public class DamageAreaCircleScaleMotion : DamageAreaScaleMotion
{
    private DamageAreaCircleData _circleData;

    public override void Initialize(DamageAreaRunner areaRunner)
    {
        Runner = areaRunner;
        TimeData = areaRunner.DamageAreaData.TimeData;
        _circleData = (DamageAreaCircleData)areaRunner.DamageAreaData.ShapeData;

        Runner.OnStateChanged
            .Subscribe(state =>
            {
                switch (state._State)
                {
                    case DamageAreaState.Spawn:
                        {
                            transform.localPosition = _circleData.CenterPosition;

                            transform.localScale = Vector3.zero;
                            transform
                                .DOScale(Vector3.one * _circleData.Radius, TimeData.SpawnTime)
                                .SetEase(Ease.OutSine);
                        }
                        break;
                    case DamageAreaState.FadeOut:
                        {
                            transform
                                .DOScale(Vector3.zero, TimeData.FadeOutTime)
                                .SetEase(Ease.OutSine);
                        }
                        break;
                }
            });
    }
}
