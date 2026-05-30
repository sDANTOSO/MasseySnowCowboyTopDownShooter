using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public GameObject projectilePrefab;
     //public Transform firePoint;
     public Transform firePointL;
     public Transform firePointR;

     void Update()
     {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Ensure the z-coordinate is zero for 2D
        Vector3 direction = mousePosition - transform.position;
        direction = direction.normalized;

        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            GameObject projectile = Instantiate(projectilePrefab, firePointL.position, Quaternion.identity);
            GameObject projectile2 = Instantiate(projectilePrefab, firePointR.position, Quaternion.identity);

            Projectile projectileScript = projectile.GetComponent<Projectile>();
            projectileScript.SetDirection(direction);

            Projectile projectileScript2 = projectile2.GetComponent<Projectile>();
            projectileScript2.SetDirection(direction);
        }
     }

}
