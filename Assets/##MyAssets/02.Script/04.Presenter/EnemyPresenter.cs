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
        _player = FindObjectOfType<PlayerPresetner>();
        _healthBar = GetComponentInChildren<Image>();
    }
    
    private void AIMove()
    {
        // calculate distance for player and enemy
        var distance = Vector2.Distance(_player.transform.position, transform.position);
        if (distance < 1) _model.Attack.Attack();
        else if (distance < 5) _move.Movement(_player.transform.position, _model.Speed);
        else _move.Movement(_model.SpawnPoint.position, _model.Speed);
    }
}
