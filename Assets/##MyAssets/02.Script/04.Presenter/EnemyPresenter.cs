using System;
using RNBUtil;
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
        
        // play attack animation when every 2second and distance is less than 1
        this.UpdateAsObservable()
            .Where(_ => model.health.Value >= 0)
            .Where(_ =>  CalculDistance(player.transform.position,transform.position) < 1)
            .ThrottleFirst(TimeSpan.FromSeconds(model.AttackDelay))
            .Subscribe(_ => model.Attack.Attack())
            .AddTo(this);
    }
    
    private void AIMove()
    {
        // calculate distance for player and enemy
        var playerPosition = player.transform.position;
        var currentPosition = transform.position;
        var distance = CalculDistance(playerPosition, currentPosition);
        if (distance > 1) move.Movement((playerPosition - currentPosition).normalized, model.Speed);
    }
    
    private float CalculDistance(Vector3 playerPosition, Vector3 currentPosition)
    {
        return Mathf.Sqrt((playerPosition.x - currentPosition.x) * (playerPosition.x - currentPosition.x) +
                          (playerPosition.y - currentPosition.y) * (playerPosition.y - currentPosition.y));
    }
}
