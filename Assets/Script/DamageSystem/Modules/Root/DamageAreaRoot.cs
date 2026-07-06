using UnityEngine;

public class DamageAreaRoot : MonoBehaviour
{
    public DamageAreaRunner Runner {  get; private set; }
    public DamageAreaScaleMotion ScaleMotion { get; private set; }

    private void Awake()
    {
        Runner = GetComponent<DamageAreaRunner>();
        ScaleMotion = GetComponent<DamageAreaScaleMotion>();
    }

    public void Initialize(DamageAreaData data)
    {
        Runner.Initialize(data);
        ScaleMotion.Initialize(data);
    }

    public void Run()
    {
        _ = Runner.Run();
    }
}
