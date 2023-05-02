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

    private void Update()
    {
        //Get the input
        var input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Get the target position
        var targetPosition = transform.position + new Vector3(input.x, input.y, 0);
        //Move the player
        Movement(input, 5, targetPosition);
    }
}
