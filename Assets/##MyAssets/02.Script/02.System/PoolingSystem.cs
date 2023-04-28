using RNBExtensions;
using UnityEngine;

public class PoolingSystem : MonoBehaviour
{
     // 오브젝트 풀링
     // 초기에 생성해놓고 필요할 때마다 꺼내서 사용하는 방식
     // 싱글톤으로 풀을 만들고 자식 오브젝트로 생성해놓는다.
     // 필요할 때, 풀에서 꺼내서 사용하고 사용이 끝나면 다시 풀에 넣는다.
     // 풀에 넣을 때는 비활성화 시킨다.
     public static PoolingSystem Instance;
     
     [SerializeField] private GameObject prefab;
     [SerializeField] private int count;
     [SerializeField] private Transform parent;
     [SerializeField] private int limitCount;
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
          for (var i = 0; i < count; i++)
          {
               var obj = Instantiate(prefab, parent);
               obj.SetActive(false);
          }
     }
     
     public GameObject GetObject(Transform spawnPoint)
     {
          // 풀에 넣을 때, 풀이 가득 찼을 때
          if (parent.childCount >= limitCount) return null;
          // 풀에서 꺼내기
          foreach (Transform child in parent)
          {
               if (child.gameObject.activeSelf) continue;
               var chileObject = child.gameObject;
               chileObject.SetActive(true);
               chileObject.transform.SetLocalTransform(spawnPoint.position, spawnPoint.rotation);
               return chileObject;
          }
          // 풀에 더 이상 사용할 오브젝트가 없을 때
          var obj = Instantiate(prefab, parent);
          obj.SetActive(true);
          obj.transform.SetLocalTransform(spawnPoint.position, spawnPoint.rotation);
          return obj;
     }
     
     public void ReturnObject(GameObject obj)
     {
          // 풀에 넣기
          obj.SetActive(false);
          obj.transform.SetParent(parent);
     }
}
