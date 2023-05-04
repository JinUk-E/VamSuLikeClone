using TMPro;
using UnityEngine;

public class ScorePresenter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    
    public void OnScoreChanged(int score) => scoreText.text = $"Score: {score}";
    
}
