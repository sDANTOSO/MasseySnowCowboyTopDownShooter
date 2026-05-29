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

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collided with " + collision.gameObject.name);
        Damageable damageable = collision.gameObject.GetComponent<Damageable>();

         if (damageable != null)
        {
        damageable.TakeDamage(damage);
        }

        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {   
        
        
        //string firstDigit = rightVec.x.ToString("F2").Substring(0, 1);
        //Vector3 rightVec = transform.right;
        //if (rightVec.x < 0)
        //{
        //    rightVec.x = 1f;
        //}
        
        //transform.right = rightVec;

        
        transform.position += moveDirection * speed * Time.deltaTime;
        print(transform.right+""+transform.rotation);
    }
}
