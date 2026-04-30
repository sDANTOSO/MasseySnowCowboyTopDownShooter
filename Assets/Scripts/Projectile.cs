using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 8f;
    public float lifetime = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {   
        //string firstDigit = rightVec.x.ToString("F2").Substring(0, 1);
        Vector3 rightVec = transform.right;
        if (rightVec.x < 0)
        {
            rightVec.x = 1f;
        }
        
        transform.right = rightVec;

        
        transform.position += transform.right * speed * Time.deltaTime;
        print(transform.right+""+transform.rotation);
    }
}
