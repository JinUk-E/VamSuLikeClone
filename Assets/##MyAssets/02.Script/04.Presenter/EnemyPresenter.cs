using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPresenter : MonoBehaviour
{
    [SerializeField] private Enemy model;
    [SerializeField] private EnemyMovement move;
    [SerializeField] private Image healthBar;
    [SerializeField] private PlayerPresenter player;

    private void Awake() => player = FindObjectOfType<PlayerPresenter>();

    private void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => model.health.Value >= 0)
            .Subscribe(_ => AIMove())
            .AddTo(this);
        
        // this.UpdateAsObservable()
        //     .Where(_ => model.health.Value >= 0)
        //     .Subscribe(_ => healthBar.fillAmount = model.health.Value / 100f)
        //     .AddTo(this);
        
        // play attack animation when player is in attack range and 2 seconds later, attack to player
        this.UpdateAsObservable()
            .Where(_ => model.health.Value >= 0)
            .Where(_ => Vector2.Distance(transform.position, player.transform.position) <= 1)
            .Delay(TimeSpan.FromSeconds(2))
            .Subscribe(_ => AIAttack())
            .AddTo(this);
    }
    
    private void AIMove()
    {
        // calculate distance for player and enemy
        var playerPosition = player.transform.position;
        var currentPosition = transform.position;
        var distance = Mathf.Sqrt((playerPosition.x - currentPosition.x) * (playerPosition.x - currentPosition.x) +
                                  (playerPosition.y - currentPosition.y) * (playerPosition.y - currentPosition.y));
        if (distance > 1) move.Movement((playerPosition - currentPosition).normalized, model.Speed);
    }

    private void AIAttack() => model.Attack.Attack();
}
