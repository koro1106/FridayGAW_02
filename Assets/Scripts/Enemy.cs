using UnityEngine;

/// <summary>
/// ìGóp
/// </summary>
public class Enemy : MonoBehaviour
{
    public float speed = 3f;

    public int maxHP = 100;
    private int currentHP;

    private Transform player;
    // ì|ÇµÇΩéûÇ…Ç‡ÇÁÇ¶ÇÈì_êî
    public int scoreValue = 100;
    void Start()
    {
        currentHP = maxHP;

        GameObject p = GameObject.FindGameObjectWithTag("Player");
        if (p != null)
            player = p.transform;
    }

    void Update()
    {
        if (player == null) return;

        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        transform.LookAt(player);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // ÉXÉRÉAâ¡éZ
        ScoreManager.instance.AddScore(scoreValue);
        Destroy(gameObject);
    }

    public float GetHPPercent()
    {
        return (float)currentHP / maxHP;
    }
}