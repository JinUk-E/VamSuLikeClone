using UnityEngine;

public class EnemyMovement : MonoBehaviour, IMovable
{
    // use AI for movement
    // move to player
    // calculate distance for player and enemy
    // if distance is less than 5, move to player
    // if distance is less than 1, attack to player
    // if distance is more than 5, move to random position
    // if distance is more than 10, move to start position
    // if enemy's life is 0, return to pool
    public void Movement(Vector2 direction, float speed)
    {
        //Move the enemy
        transform.position += (Vector3)direction * (speed * Time.deltaTime);
    }
}
