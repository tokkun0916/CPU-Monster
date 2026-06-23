using UnityEngine;

public class HogeTest : MonoBehaviour
{
    void Start()
    {
        DamageAreaCircleView damageArea = new DamageAreaCircleView();
        damageArea.Initialize(new DamageAreaCircleData
        {
            _Center = new Vector3(0, 0, 0),
            _Height = 5.0f,
            _Radius = 3.0f,
            _Angle = 90.0f
        });
    }
}
