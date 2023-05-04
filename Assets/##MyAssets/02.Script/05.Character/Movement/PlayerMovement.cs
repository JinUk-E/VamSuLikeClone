using UnityEngine;

public class PlayerMovement : MonoBehaviour,IMovable
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    public void Movement(Vector2 direction, float speed)
    {
        //Move the player
        transform.position += (Vector3)direction * (speed * Time.deltaTime);
        spriteRenderer.flipX = direction.Equals(Vector2.left);
    }
}
