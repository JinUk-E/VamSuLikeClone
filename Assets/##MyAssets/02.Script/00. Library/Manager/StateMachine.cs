using System;
using RNBExtensions;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private BasicEnum.State _state;
    public void SetState(BasicEnum.State newState) => _state = newState;
    private void Awake() => SetState(BasicEnum.State.Idle);
    // public state machine method
    public void ChangeState(BasicEnum.State newState)
    {
        if (_state == newState) return;
        SetState(newState);
        switch (_state)
        {
            case BasicEnum.State.Idle:
                Idle();
                break;
            case BasicEnum.State.Move:
                Move();
                break;
            case BasicEnum.State.Attack:
                Attack();
                break;
            case BasicEnum.State.Dead:
                Dead();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void Idle() => Debug.Log("Idle");
    private void Move() => Debug.Log("Move");
    private void Attack() => Debug.Log("Attack");
    private void Dead() => Debug.Log("Dead");
}
