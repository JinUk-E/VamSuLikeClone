using UnityEngine;

public class PlayerPresetner : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private AbstractAttack playerAttack;
    [SerializeField] private float moveSpeed;
    // Player Controller setting with Update
    private void Update()
    {
        // Player Controller
        if (Input.GetKeyDown(KeyCode.Space)) playerAttack.Attack();
        // input key down with w,a,s,d
        InputMoveKey();
    }

    private void InputMoveKey()
    {
        // input key down with w,a,s,d
        var inputKey = Input.GetKey(KeyCode.W) ? Vector2.up :
            Input.GetKey(KeyCode.A) ? Vector2.left :
            Input.GetKey(KeyCode.S) ? Vector2.down :
            Input.GetKey(KeyCode.D) ? Vector2.right : Vector2.zero;
        // if input key down
        if (inputKey != Vector2.zero)
        {
            // player movement
            playerMovement.Movement(inputKey, moveSpeed);
        }
    }
}
