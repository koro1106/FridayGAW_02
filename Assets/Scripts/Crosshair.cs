using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public RectTransform crosshairRect;

    void Start()
    {
        if (crosshairRect != null)
        {
            // ‰æ–Ê’†‰›‚ÉŒÅ’è
            crosshairRect.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        }
    }
}