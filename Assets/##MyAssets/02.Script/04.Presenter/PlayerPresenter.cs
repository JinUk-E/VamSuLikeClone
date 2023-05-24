using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class PlayerPresenter : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Player playerModel;
    
    // Player movement and Attack Stream for UniRx
    private void Start()
    {
        this.FixedUpdateAsObservable()
            .Select(_ => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized)
            .Where(v => !v.Equals(Vector2.zero))
            .Subscribe(v => playerMovement.Movement(v, playerModel.MoveSpeed))
            .AddTo(this);
        
        this.UpdateAsObservable()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Subscribe(_ => playerModel.Attack.Attack())
            .AddTo(this);
    }

}
