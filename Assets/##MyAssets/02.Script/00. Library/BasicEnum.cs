namespace RNBExtensions
{
    public class BasicEnum
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
    
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
            Die
        }
    }
}
