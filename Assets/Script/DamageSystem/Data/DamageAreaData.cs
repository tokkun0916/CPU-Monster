public class DamageAreaData
{
    public DamageAreaShapeBaseData ShapeData;
    public DamageAreaAttackData AttackData;
    public DamageAreaTimeData TimeData;

    public DamageAreaData(
        DamageAreaShapeBaseData shapeData,
        DamageAreaAttackData attackData,
        DamageAreaTimeData timeData)
    {
        ShapeData = shapeData;
        AttackData = attackData;
        TimeData = timeData;
    }
}
