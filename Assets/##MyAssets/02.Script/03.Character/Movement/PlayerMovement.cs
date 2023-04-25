using UnityEngine;

public class PlayerMovement : MonoBehaviour,IMovable
{
    public void Movement(Vector2 direction, float speed, Vector2 targetPosition)
    {
        //Move the player
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        //Rotate the player
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
}
