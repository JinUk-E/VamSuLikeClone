using UnityEngine;

public class Spawn : MonoBehaviour
{
    [field: SerializeField] public float SpawnDelay { get; private set; } = 1.0f;
    [field: SerializeField] public GameObject EnemyPrefab { get; private set; }
    [field: SerializeField] public Transform spawnPoint { get; private set; }
}
