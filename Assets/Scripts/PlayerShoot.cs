using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public Camera playerCamera;  // メインカメラ
    public int damage = 10;
    public float range = 100f;

    public int maxAmmo = 10;  // 最大弾数
    private int currentAmmo;

    void Start()
    {
        currentAmmo = maxAmmo;
    }
    void Update()
    {
        // リロード（Rキー）
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            Reload();
        }
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        Shoot();
    }

    void Shoot()
    {
        // 弾がないなら撃てない
        if (currentAmmo <= 0)
        {
            Debug.Log("弾切れ！");
            return;
        }

        currentAmmo--;

        // クロスヘアのスクリーン座標（画面中央）
        Vector3 crosshairPos = new Vector3(Screen.width / 2, Screen.height / 2, 0);

        // スクリーン座標からRayを生成
        Ray ray = playerCamera.ScreenPointToRay(crosshairPos);

        // Raycast判定
        if (Physics.Raycast(ray, out RaycastHit hit, range))
        {
            Enemy enemy = hit.collider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Debug.Log("Enemy hit!");
            }
        }
    }
    void Reload()
    {
        currentAmmo = maxAmmo;
        Debug.Log("リロード完了！");
    }
}