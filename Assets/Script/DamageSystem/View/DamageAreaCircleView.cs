using UnityEngine;

public class DamageAreaCircleView : MonoBehaviour
{
    private DamageAreaCircleData _data;

    public void Initialize(DamageAreaShapeBaseData shapeData)
    {
        _data = shapeData as DamageAreaCircleData;

        Debug.Log($"DamageAreaCircleView initialized with Center: {_data._Center}, Height: {_data._Height}, Radius: {_data._Radius}, Angle: {_data._Angle}");
    }
}
