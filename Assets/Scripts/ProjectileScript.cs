using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 8f;
    public float lifetime = 2f;

    public float damage = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 moveDirection;

    public void SetDirection(Vector3 direction)
    {
        moveDirection = direction;
    }

     // Update is called once per frame
    void Update(){   
        
        //string firstDigit = rightVec.x.ToString("F2").Substring(0, 1);
        //Vector3 rightVec = transform.right;
        //if (rightVec.x < 0)
        //{
        //    rightVec.x = 1f;
        //}
        //transform.right = rightVec;

        transform.position += moveDirection * speed * Time.deltaTime;
        //print(transform.right+""+transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy")|| collision.collider.CompareTag("Laserbeam"))
        {
         print("Collided with " + collision.gameObject.name);
        
        print("it survived");
        DamageableEnemy damageableenemy = collision.gameObject.GetComponent<DamageableEnemy>();

         if (damageableenemy != null)
        {
             print("Dealing damage to " + collision.gameObject.name);
            PointManager.Instance.AddPoints(4);
            damageableenemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        }else{
        if (collision.collider.CompareTag("Snakekillable")){
         print("Collided with " + collision.gameObject.name);
        SnakeDamage snakeDamage = collision.gameObject.GetComponent<SnakeDamage>();

         if (snakeDamage != null)
        {
             print("Dealing damage to " + collision.gameObject.name);
             PointManager.Instance.AddPoints(6);
            snakeDamage.TakeDamage(damage);
        }

        Destroy(gameObject);
        }
            else{
                Destroy(gameObject);
        }

   
    }
    }}
