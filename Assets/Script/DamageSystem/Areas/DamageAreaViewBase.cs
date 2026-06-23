using UnityEngine;

public abstract class DamageAreaViewBase : MonoBehaviour
{
    protected DamageAreaTimeData _timeData;

    public abstract void Initialize(DamageAreaTimeData timeData);
}