using UnityEngine;
/// <summary>
/// ’e‘¤‚ÌScript
/// </summary>
public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // “G‚É“–‚½‚Á‚½‚¾‚¯ˆ—
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // “Gíœ
            Destroy(gameObject);       // ’eíœ
        }
    }
}