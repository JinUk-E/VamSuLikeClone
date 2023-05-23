using System;
using RNBExtensions;
using UniRx;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private SpawnPointModel spawnPointModel;
    [SerializeField] private int limitCount;
    
    private void SpawnMonster()
    {
        // get random spawn point
        var spawnPoint = spawnPointModel.GetRandomSpawnPoint().transform;
        var spawnType = (BasicEnum.SpawnType) UnityEngine.Random.Range(0, 3);
        // get random monster
        PoolingSystem.Instance.GetObject(spawnType.ToString(), spawnPoint,limitCount);
    }
    
    // Spawn Monster until the game is over or score is 100 with uniRx
    private void Start()
    {
        // spawn monster every 2 seconds limit 4
        Observable.Interval(TimeSpan.FromSeconds(2))
            .Subscribe(_ => SpawnMonster())
            .AddTo(this);
    }
    
}
