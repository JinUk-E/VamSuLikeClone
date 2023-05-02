using System;
using RNBExtensions;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private BasicEnum.State _state;
    public void SetState(BasicEnum.State newState) => _state = newState;
    private void Awake() => SetState(BasicEnum.State.Idle);
    private void Update()
    {
        switch (_state)
        {
            case BasicEnum.State.Idle:
                // Do Something
                // around current position
                break;
            case BasicEnum.State.Move:
                // Do Something
                // prefabs move to target
                break;
            case BasicEnum.State.Attack:
                // Do Something
                // Maybe Play Animation
                break;
            case BasicEnum.State.Die:
                // Do Something
                // Maybe Return to Pool or Destroy
                // gameObject.SetActive(false);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
