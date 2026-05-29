using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// カメラ操作
/// </summary>
public class CameraCtrl : MonoBehaviour
{
     public Transform playerBody; // 親（プレイヤー本体）

    public float mouseSensitivity = 200f;

    float xRotation = 0f;

    Vector2 lookInput;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        // 上下（カメラだけ）
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // 左右（プレイヤー回転）
        playerBody.Rotate(Vector3.up * mouseX);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
}