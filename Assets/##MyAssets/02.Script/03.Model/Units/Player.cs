using UniRx;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public AbstractAttack Attack { get; set; }
    [field: SerializeField] public ReactiveProperty<float> health { get; set; }
}
