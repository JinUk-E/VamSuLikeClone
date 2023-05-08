using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour, IMovable
{
    // use AI for movement
    // move to player
    // calculate distance for player and enemy
    // if distance is less than 1, attack to player
    // if enemy's life is 0, return to pool
    public void Movement(Vector2 direction, float speed) =>    transform.position += (Vector3)direction * (speed * Time.deltaTime);
}
