namespace RNBExtensions
{
    public class BasicEnum
    {
       
        public enum AttackType
        {
            None,
            Melee,
            Range,
            Magic
        }
    
        public enum AttackElement
        {
            None,
            Fire,
            Ice,
            Poison
        }
        
        public enum State
        {
            Idle,
            Move,
            Attack,
            Dead
        }
        
        public enum SpawnType
        {
            Monster1,
            Monster2,
            Monster3
        }
    }
}
