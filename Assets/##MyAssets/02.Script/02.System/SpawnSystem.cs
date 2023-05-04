using System;
using UniRx;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private SpawnPointModel spawnPointModel;
    // create singleton
    private void SpawnMonster()
    {
        // get random spawn point
        var spawnPoint = spawnPointModel.GetRandomSpawnPoint().transform;
        // get random monster
        PoolingSystem.Instance.GetObject("Monster1", spawnPoint);
    }
    
    // Spawn Monster every 3 seconds until the game is over or score is 100 with uniRx
    // private void Start()
    // {
    //     Observable.Interval(TimeSpan.FromSeconds(3))
    //         .TakeUntil(Observable.EveryUpdate().Where(_ => GameManager.Instance.IsGameOver || GameManager.Instance.Score >= 100))
    //         .Subscribe(_ => SpawnMonster());
    // }
    
}
