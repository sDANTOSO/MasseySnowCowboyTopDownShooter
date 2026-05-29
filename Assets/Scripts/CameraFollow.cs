using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public float followSpeed = 5f; // The speed at which the camera will follow the target
    public float yset=-2.02f; // The fixed y position for the camera
    void Update()
    {
        print ("camera is updating");
        
        if (target.position.x>11 && target.position.x<30) {

            Vector3 targetPosition = new Vector3(target.position.x, yset, transform.position.z); // Keep the camera's z position unchanged

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime); // Smoothly move the camera towards the target position


        }
            else if (target.position.x>30 && target.position.x<50) {
    
                Vector3 targetPosition = new Vector3(target.position.x, yset, transform.position.z); // Keep the camera's z position unchanged
    
                transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime); // Smoothly move the camera towards the target position
    }
}
}
