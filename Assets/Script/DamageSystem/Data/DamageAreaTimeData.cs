public class DamageAreaTimeData
{
    public float SpawnTime = 0.3f;
    public float AttackWaitTime = 0.6f;
    public float AttackTime = 1.0f;
    public float FadeOutTime = 0.3f;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="spawnTime">出現モーションにかかる時間</param>
    /// <param name="attackWaitTime">攻撃発動までの時間</param>
    /// <param name="attackTime">攻撃判定の時間</param>
    /// <param name="fadeOutTime">消滅モーションにかかる時間</param>
    public DamageAreaTimeData(
        float spawnTime,
        float attackWaitTime,
        float attackTime,
        float fadeOutTime)
    {
        SpawnTime = spawnTime;
        AttackWaitTime = attackWaitTime;
        AttackTime = attackTime;
        FadeOutTime = fadeOutTime;
    }
}
