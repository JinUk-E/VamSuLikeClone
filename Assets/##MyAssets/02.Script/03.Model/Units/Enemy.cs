using RNBExtensions;
using UniRx;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [field: SerializeField] public AbstractAttack Attack { get; set; }
    [field: SerializeField] public BasicEnum.State State { get; set; }
    [field: SerializeField] public ReactiveProperty<float> health { get; set; } = new(100f);
    [field: SerializeField] public float Speed { get; set; } = 1.0f;
}
