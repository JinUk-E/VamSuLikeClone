using UnityEngine;

public class MeleeAttack : AbstractAttack
{
    protected override void AttackImpl(string name)
    {
        Debug.Log($"{name} Melee Attack");
        //Damage calculate
    }
}
