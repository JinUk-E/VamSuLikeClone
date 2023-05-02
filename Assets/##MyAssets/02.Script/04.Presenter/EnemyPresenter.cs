using RNBExtensions;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPresenter : MonoBehaviour
{
    [SerializeField] private Enemy model;
    [SerializeField] private EnemyMovement move;
    [SerializeField] private Image healthBar;
    private void Awake()
    {
        model = GetComponent<Enemy>();
        move = GetComponent<EnemyMovement>();
    }
    
    private void Start()
    {
        model.Attack.Subscribe(attack => attack.Attack());
        model.health.Subscribe(health => healthBar.fillAmount = health / 100.0f);
        model.State = BasicEnum.State.Idle;
    }
    
    
}
