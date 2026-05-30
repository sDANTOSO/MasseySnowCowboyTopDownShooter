using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 6.6f;
    private Vector3 moveDirection;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     moveDirection.x = Input.GetAxisRaw("Horizontal");
     moveDirection.y = Input.GetAxisRaw("Vertical");
     moveDirection.z = 0f;
        //Vector3 currentPos = transform.position;
        //print (transform.position.x);

    //Transform target = transform.position += moveDirection * moveSpeed * Time.deltaTime;

    //if (target.transform.position.x > 0 && target.transform.position.x +3< 41 && target.transform.position.y+3 > -7 && target.transform.position.y +3<3) {
     

     float moveHorizontal = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
     transform.Translate(moveHorizontal, 0f, 0f);
     float moveVertical = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
     transform.Translate(0f, moveVertical, 0f);
    
    float clampedX = Mathf.Clamp(transform.position.x, -0.1f, 38f);
    float clampedY = Mathf.Clamp(transform.position.y, -7f, 2.8f);

    
    //print(moveDirection);
    transform.position = new Vector3(clampedX, clampedY, transform.position.z);

     //Vector3 transformposition =(Mathf.Clamp(transform.position.x, 0, 41), Mathf.Clamp(transform.position.y, -7, 3), 0.0f); 


     moveDirection = moveDirection.normalized; 
     //print(moveDirection);

     transform.position += moveDirection * moveSpeed * Time.deltaTime;
    
     
  // }
        if (moveDirection.x > 0)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else if (moveDirection.x < 0)
        {
            spriteRenderer.flipX = true; // Face left
        }

        if (moveDirection.y > 0)
        {
            spriteRenderer.flipY = false; // Face right
        }
        else if (moveDirection.y < 0)
        {
            spriteRenderer.flipY = true; // Face left
        }
    }
}
