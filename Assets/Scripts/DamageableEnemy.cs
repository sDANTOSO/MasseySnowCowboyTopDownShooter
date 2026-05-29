using UnityEngine;

public class DamageableEnemy : MonoBehaviour
{
    public float maxHealth = 10f;
    public float currentHealth;
    public GameObject turret1;
    public GameObject turret2;


    void Start()
    {
        currentHealth = maxHealth;
    }

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
        Destroy(turret1);
        Destroy(gameObject);
    }

}
