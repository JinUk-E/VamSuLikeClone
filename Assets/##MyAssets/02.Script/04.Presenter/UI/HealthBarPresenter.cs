using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarPresenter : MonoBehaviour
{
    [SerializeField] private Image healthBarUI;
    private readonly float maxHealth = 100f;
    private Collider _collider;
    
    // awake initialize for collider and healthbar
    private void Awake()
    {
        _collider = GetComponent<Collider>();
        healthBarUI.fillAmount = 1f;
    }
    
    // when health is changed, healthbar is changed
    public void Start()
    {
        // todo : Damage Event from Enemy
        _collider.OnTriggerEnterAsObservable()
            .Where(other => other.CompareTag("Enemy"))
            .Subscribe(_ => OnDamage(10f))
            .AddTo(this);
    }
    
    // get damage then changed healthbar value and color
    private void OnDamage(float damage)
    {
        healthBarUI.fillAmount -= damage;
        healthBarUI.color = Color.Lerp(Color.red, Color.green, healthBarUI.fillAmount);
    }
}
