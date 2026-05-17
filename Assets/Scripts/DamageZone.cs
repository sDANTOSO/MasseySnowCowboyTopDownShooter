using UnityEngine;

public class DamageZone : MonoBehaviour
{
  public float damagePerSecond = 50f; // Amount of damage to apply to the player per second


    void OnTriggerStay2D(Collider2D collision)


    {
        print("Player is in damage zone");
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damagePerSecond * Time.deltaTime);
            }
        }
    }
}
