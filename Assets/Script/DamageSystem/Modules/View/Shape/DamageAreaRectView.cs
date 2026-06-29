using DG.Tweening;
using UnityEngine;
using UniRx;

public class DamageAreaRectView : DamageAreaView
{
    public override void Initialize(DamageAreaRunner areaRunner)
    {
        Runner = areaRunner;
        TimeData = areaRunner.DamageAreaData.TimeData;
        ShapeData = areaRunner.DamageAreaData.ShapeData;

        Runner.OnStateChanged
            .Subscribe(state =>
            {
                switch (state._State)
                {
                    case DamageAreaState.FadeIn:
                        {
                            transform.localScale = Vector3.zero;

                            // ここに矩形のサイズを設定する処理を追加する

                            transform
                                .DOScale(Vector3.one, TimeData.FadeInTime)
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
