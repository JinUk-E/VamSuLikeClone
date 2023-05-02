using UnityEngine;

public interface IMovable
{
    //targetPosition: The position to move to
    public void Movement(Vector2 direction, float speed);
}
