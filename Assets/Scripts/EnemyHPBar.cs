using UnityEngine;
using UnityEngine.UI;

public class EnemyHPBar : MonoBehaviour
{
    public Enemy enemy;
    public Slider slider;
    public Vector3 offset = new Vector3(0, 2f, 0);
    public Camera cam;

    void Start()
    {
        if (cam == null)
            cam = Camera.main;
    }

    void Update()
    {
        if (enemy == null) return;

        // HP更新
        slider.value = enemy.GetHPPercent();

        // 敵の頭上に追従
        transform.position = enemy.transform.position + offset;

        // カメラの方を向く（超重要）
        transform.forward = cam.transform.forward;
    }
}