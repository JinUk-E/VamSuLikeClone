using System.Collections.Generic;
using RNBExtensions;
using RNBUtil;
using UnityEngine;

public class PoolingSystem : AtGameSingleton<PoolingSystem>
{
     // 오브젝트 풀링
     // 초기에 생성해놓고 필요할 때마다 꺼내서 사용하는 방식
     // 싱글톤으로 풀을 만들고 자식 오브젝트로 생성해놓는다.
     // 필요할 때, 풀에서 꺼내서 사용하고 사용이 끝나면 다시 풀에 넣는다.
     // 풀에 넣을 때는 비활성화 시킨다.
     public static PoolingSystem Instance => instance;

     [SerializeField] private ObjectPool[] objectPool;
     private Dictionary<string,ObjectPool> _poolDictionary = new();

     private void Start()
     {
          // 풀 생성
          foreach (var model in objectPool)
          {
               DebugerEx.Logger(model.name.Bold(), DebugerEx.DebugType.LogWarning);
               _poolDictionary.Add(model.name, model);
          }
               
     }

     public GameObject GetObject(string objectName, Transform spawnPoint)
     {
          if (_poolDictionary.ContainsKey(objectName)) return _poolDictionary[objectName].GetObject(spawnPoint);
          DebugerEx.Logger($"{objectName} 풀이 존재하지 않습니다.", DebugerEx.DebugType.LogError);
          return null;
     }

     public void ReturnObject(string objectName, GameObject obj) => _poolDictionary[objectName].ReturnObject(obj);
}
