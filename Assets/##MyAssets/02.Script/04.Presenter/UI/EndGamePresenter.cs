using UnityEngine;

public class EndGamePresenter : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    public void OnGameOver() => gameOverUI.SetActive(true);
    
    //SceneLoader
    
}
