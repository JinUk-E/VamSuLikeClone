using System.Collections.Generic;
using UnityEngine;

public class PoolingSystem : MonoBehaviour
{
     // 오브젝트 풀링
     // 초기에 생성해놓고 필요할 때마다 꺼내서 사용하는 방식
     // 싱글톤으로 풀을 만들고 자식 오브젝트로 생성해놓는다.
     // 필요할 때, 풀에서 꺼내서 사용하고 사용이 끝나면 다시 풀에 넣는다.
     // 풀에 넣을 때는 비활성화 시킨다.
     public static PoolingSystem Instance;
     
     [SerializeField] private ObjectPool[] objectPool;
     private Dictionary<string,ObjectPool> poolDictionary = new();
    
     private void Awake()
     {
          // 중복 생성 예외 처리
          if (Instance != null)
          {
               Destroy(gameObject);
               return;
          }
          Instance = this;
     }

     private void Start()
     {
          // 풀 생성
          foreach (var model in objectPool) poolDictionary.Add(model.name, model);
     }

     public GameObject GetObject(string objectName, Transform spawnPoint) => poolDictionary[objectName].GetObject(spawnPoint);
     public void ReturnObject(string objectName, GameObject obj) => poolDictionary[objectName].ReturnObject(obj);
}
