using UnityEngine;

public abstract class DamageAreaView : MonoBehaviour
{
    protected DamageAreaRunner Runner;
    protected DamageAreaTimeData TimeData;
    protected DamageAreaShapeBaseData ShapeData;

    public abstract void Initialize(DamageAreaRunner area);
}