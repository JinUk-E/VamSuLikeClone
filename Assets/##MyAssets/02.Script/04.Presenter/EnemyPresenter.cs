using UnityEngine;
using UnityEngine.UI;

public class EnemyPresenter : MonoBehaviour
{
    private Enemy _model;
    private EnemyMovement _move;
    private Image _healthBar;
    private PlayerPresetner _player;
    private void Awake()
    {
        _model = GetComponent<Enemy>();
        _move = GetComponent<EnemyMovement>();
    }
    
    private void Start()
    {
        
        

    }
    
    // enemy movement setting to calculate distance for player and enemy with uniRx
    private void AIMove()
    {
        // calculate distance for player and enemy
        var distance = Vector2.Distance(_player.transform.position, transform.position);
    }
}
