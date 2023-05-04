using RNBExtensions;

public class MagicAttack : AbstractAttack
{
    protected override void AttackImpl()
    {
        attackType = BasicEnum.AttackType.Magic;
        
    }
}
