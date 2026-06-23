public abstract class DamageArea
{
    public abstract void Execute();
}

public abstract class DamageArea<TShape> : DamageArea
    where TShape : DamageAreaShapeBaseData
{
    protected AttackData _AttackData;
    protected TShape _ShapeData;

    public virtual void Initialize(AttackData attackData)
    {
        _AttackData = attackData;
        _ShapeData = (TShape)attackData._ShapeData;
    }
}
