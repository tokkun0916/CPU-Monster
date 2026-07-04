using UnityEngine;

public class DamageAreaManager : MonoBehaviour
{
    [SerializeField] DamageAreaSpwaner _damageAreaSpawner;
    [SerializeField] DamageAreaFactory _damageAreaFactory;
    [SerializeField] HogeDamageAreaInstantiate _hogeDamageAreaInstantiate;

    void Start()
    {
        _damageAreaFactory.Initialize(_hogeDamageAreaInstantiate);
        _damageAreaSpawner.Initialize(_damageAreaFactory);
    }
}
