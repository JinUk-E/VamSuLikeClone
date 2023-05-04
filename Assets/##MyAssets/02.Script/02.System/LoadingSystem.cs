using System;

public class LoadingSystem : SceneLoadManager
{
    public override void LoadScene(string sceneName)
    {
        // Loading Scene with SceneName
        var filling = GetComponent<FillingLoadingBar>();
        gameObject.SetActive(true);
        StartCoroutine(filling.Load(LoadAsyncOperation(sceneName)));
    }

    public override void LoadScene(string sceneName, Action callback)
    {
        LoadScene(sceneName);
        callback?.Invoke();
    }
}
