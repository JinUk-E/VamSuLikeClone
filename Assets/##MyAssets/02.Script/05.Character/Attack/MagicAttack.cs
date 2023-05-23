using RNBExtensions;

public class MagicAttack : AbstractAttack
{
    protected override void AttackImpl(string name)
    {
        attackType = BasicEnum.AttackType.Magic;
    }
}
