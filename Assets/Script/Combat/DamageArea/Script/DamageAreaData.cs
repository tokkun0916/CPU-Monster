using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DamageArea
{
    /// <summary>
    /// ダメージエリアのデータを格納するクラス
    /// ダメージ値とサイズ、生成やゲージを溜める時間を設定する
    /// </summary>
    [System.Serializable]
    public class DamageAreaData
    {
        public int Damage;
        public float Size;
        public float SpawnTime;
        public float GaugeTime;
        public float AttackTime;
        public float DeleteTime;
    }

    [System.Serializable]
    public enum GaugeType
    { 
        Circle,
        Rect
    }
}