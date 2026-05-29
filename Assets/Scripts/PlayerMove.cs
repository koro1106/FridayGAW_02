using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    Vector2 moveInput;

    void Update()
    {
        Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.y;
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log("MOVE: " + moveInput);
    }
}
