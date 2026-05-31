using UnityEngine;

public class SnakeDamage : MonoBehaviour
{
    public Animator Snakeanim;
    public float maxHealth = 50.0f;
    public float currentHealth;
     public static SnakeDamage Instance;

    void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = 20.0f;
    }


    public void TakeDamage(float damageAmount)
    {
        if (Snakeanim.GetCurrentAnimatorStateInfo(0).IsName("Rising"))
        {
        currentHealth -= damageAmount;

        if (currentHealth <= 0f)
        {
            Die();
        }
        }
    }

    // Update is called once per frame
     void Die()
    {
        Destroy(gameObject);
    }
}
