using UnityEngine;

public class PlayerMovement : MonoBehaviour,IMovable
{
    public void Movement(Vector2 direction, float speed)
    {
        //Move the player
        transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);
        var quaternionY = direction.Equals(Vector2.right) ? 0 : 180;
        transform.rotation = Quaternion.Euler(0, quaternionY, 0);
    }
}
