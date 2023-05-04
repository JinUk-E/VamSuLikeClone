using RNBUtil;
using UnityEngine;

public class AtSceneSingleton<T> : MonoBehaviour where T : AtSceneSingleton<T>
{
    // SceneSingleton 싱글톤
    public static T Instance { get; private set; }
    
    private void Awake()
    {
        // 싱글톤 중복 예외처리
        if(Instance != null)
        {
            DebugerEx.Logger($"{typeof(T)}가 중복생성되어 파괴합니다.", DebugerEx.DebugType.LogError);
            Destroy(gameObject);
            return;
        }
        Instance = this as T;
    }
    
    // 씬이 종료될 때 싱글톤을 파괴
    private void OnDestroy() => Instance = null;
    
    // 씬이 종료될 때 싱글톤을 파괴
    private void OnApplicationQuit() => Instance = null;
}
