using UnityEngine;

public class PausePresenter : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    public void OnPause()
    {
        Time.timeScale = 0f;
        pauseUI.SetActive(true);
    }
    public void OnResume()
    {
        Time.timeScale = 1f;
        pauseUI.SetActive(false);
    }
}
