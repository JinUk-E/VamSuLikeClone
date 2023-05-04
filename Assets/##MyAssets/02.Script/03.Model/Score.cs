using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int score = 0;
    
    public void OnScoreChanged(int score) => this.score = score;
    public int GetScore() => score;
}
