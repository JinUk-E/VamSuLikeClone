using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class SceneLoadManager :  AtGameSingleton<SceneLoadManager>
{
    // 저장된 프리펩으로부터 로딩 씬을 띄운다.
    public static SceneLoadManager Instance
    {
        get
        {
            if(instance == null)instance =
                (FindObjectOfType<SceneLoadManager>() == null) ? 
                    Instantiate(Resources.Load<SceneLoadManager>("Prefabs/Test")) : 
                    FindObjectOfType<SceneLoadManager>();
            return instance;
        }
    }
    // 현재 씬의 이름
    public string CurrentSceneName { get; private set; }
    
    protected AsyncOperation LoadAsyncOperation(string name)
    {
        CurrentSceneName = name;
        return SceneManager.LoadSceneAsync(name);
    }
    // 씬을 로드하는 함수
    public abstract void LoadScene(string sceneName);
    public abstract void LoadScene(string sceneName, Action callback);
}

