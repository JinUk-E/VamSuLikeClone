using RNBExtensions;
using UniRx;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [field: SerializeField] public ReactiveProperty<AbstractAttack> Attack { get; set; } = new();
    [field: SerializeField] public BasicEnum.State State { get; set; }
    [field: SerializeField] public ReactiveProperty<float> health { get; set; } = new();
    [field: SerializeField] public Transform SpawnPoint { get; set; }
}
