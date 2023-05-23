using System.Collections.Generic;
using UnityEngine;

public class SpawnPointModel : MonoBehaviour
{
    [field: SerializeField] public List<Spawn> SpawnList { get; private set; } = new();

    public Spawn GetRandomSpawnPoint()
    {
        var randomIndex = Random.Range(0, SpawnList.Count);
        return SpawnList[randomIndex];
    }
    public int GetSpawnPointCount() => SpawnList.Count;
}
