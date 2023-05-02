using RNBExtensions;
using UnityEngine;

public abstract class AbstractAttack : MonoBehaviour, IAttack
{
    [SerializeField] protected float attackRange = 1.0f;
    [SerializeField] protected float attackDamage = 10.0f;
    [SerializeField] protected float attackDelay = 1.0f;
    [SerializeField] protected BasicEnum.AttackType attackType;
    public void Attack() => AttackImpl();
    protected abstract void AttackImpl();
}
