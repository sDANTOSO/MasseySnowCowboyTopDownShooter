using UnityEngine;

public class PlayerScript1 : MonoBehaviour
{
    public float moveSpeed = 6.6f;
    public Vector3 moveDirection;

    public GameObject projectilePrefab;
    public Transform firePointL;
    public Transform firePointR;

     public Vector3 facingDirection = Vector3.right; // Default facing direction
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       


    
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.y = Input.GetAxis("Vertical");
        moveDirection.z = 0f;

        moveDirection = moveDirection.normalized;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;


        if (moveDirection != Vector3.zero)
        {
            facingDirection = moveDirection; // Update facing direction based on movement
        }

        if (facingDirection !=Vector3.zero)
        {
            float angle = Mathf.Atan2(facingDirection.y, facingDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
        //  Fire projectile when space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
                Instantiate(projectilePrefab, firePointR.position, transform.rotation);
                Instantiate(projectilePrefab, firePointL.position, transform.rotation);
            
           
        }
    }
}
