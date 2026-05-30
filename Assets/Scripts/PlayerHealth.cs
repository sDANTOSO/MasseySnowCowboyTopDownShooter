using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Vector3 respawnPosition;
    public float maxHealth = 20f;
    public float currentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        respawnPosition = transform.position;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
       Respawn();
    }

     void Respawn()
    {
        transform.position = respawnPosition;
        currentHealth = maxHealth;
    }
}
