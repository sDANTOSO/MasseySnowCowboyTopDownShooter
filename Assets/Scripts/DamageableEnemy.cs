using UnityEngine;

public class DamageableEnemy : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public GameObject turret1;
    public GameObject turret2;


    void Start()
    {
        currentHealth = 30.0f;
    }

    public void TakeDamage(float damageAmount)
    {
        print(currentHealth);
        currentHealth -= damageAmount;

        print("new"+ currentHealth);
        if (currentHealth <= 0f)
        {
            print("Enemy died");
            Die();
        }
    }

    void Die()
    {
        Destroy(turret1);
        Destroy(gameObject);
    }

}
