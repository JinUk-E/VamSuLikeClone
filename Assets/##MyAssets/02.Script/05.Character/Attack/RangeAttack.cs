using UnityEngine;

public class RangeAttack : AbstractAttack
{
    protected override void AttackImpl(string name)
    {
        Debug.Log($"{name} Range Attack");
    }
}
