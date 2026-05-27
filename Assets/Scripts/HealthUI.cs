using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;

    public TextMeshProUGUI pointsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + Mathf.RoundToInt(playerHealth.currentHealth);

        pointsText.text = "Points: " + PointManager.Instance.currentPoints;
    }
}
