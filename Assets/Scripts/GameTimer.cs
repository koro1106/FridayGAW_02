using UnityEngine;

public class GameTimer : MonoBehaviour
{
    // Inspector‚Åİ’è‚·‚é
    public GameObject gameOverObject;

    void Start()
    {
        // Å‰‚Í”ñ•\¦
        gameOverObject.SetActive(false);

        // 10•bŒã‚ÉGameOverÀs
        Invoke("ShowGameOver", 10f);
    }

    void ShowGameOver()
    {
        gameOverObject.SetActive(true);
    }
}
