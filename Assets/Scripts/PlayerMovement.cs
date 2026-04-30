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

     moveDirection = moveDirection.normalized;   
     transform.position += moveDirection * moveSpeed * Time.deltaTime;

        if (moveDirection.x > 0)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else if (moveDirection.x < 0)
        {
            spriteRenderer.flipX = true; // Face left
        }
    }
}
