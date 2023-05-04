using RNBUtil;
using UnityEngine;

public class AtGameSingleton<T> : MonoBehaviour where T: MonoBehaviour
{
    // GameSingleton 싱글톤
    protected static T instance;
    
    private void Awake()
    {
        // 싱글톤 중복 예외처리
        if(instance != null)
        {
            DebugerEx.Logger($"{typeof(T)}가 중복생성되어 파괴합니다.", DebugerEx.DebugType.LogError);
            Destroy(gameObject);
            return;
        }
        instance = this as T;
        // 파괴불가 처리
        DontDestroyOnLoad(gameObject);
    }
}
