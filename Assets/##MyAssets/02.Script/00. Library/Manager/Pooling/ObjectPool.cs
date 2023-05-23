using System.Linq;
using RNBExtensions;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform parent;
    [SerializeField] private int count;
    
    private void Awake()
    {
        // 풀 생성
        for (var i = 0; i < count; i++)
        {
            var obj = Instantiate(prefab, parent);
            obj.SetActive(false);
        }
    }
     
    public GameObject GetObject(Transform spawnPoint, int limit = 0)
    {
        // 풀에 넣을 때, 풀이 가득 찼을 때
        if (parent.Cast<Transform>().Count(child => child.gameObject.activeSelf) >= limit) return null;
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
