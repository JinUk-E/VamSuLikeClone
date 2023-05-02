using RNBExtensions;
using UnityEngine;

public abstract class AbstractAttack : MonoBehaviour, IAttack
{
    [SerializeField] private float _attackRange = 1.0f;
    [SerializeField] private float _attackDamage = 10.0f;
    [SerializeField] private float _attackDelay = 1.0f;
    [SerializeField] private BasicEnum.AttackType _attackType = BasicEnum.AttackType.Melee;
    public void Attack() => AttackImpl();
    protected abstract void AttackImpl();
}
