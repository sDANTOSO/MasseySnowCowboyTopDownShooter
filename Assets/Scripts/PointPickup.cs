using UnityEngine;

public class PointPickup : MonoBehaviour
{
    public int pointValue = 10;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PointManager.Instance.AddPoints(pointValue);
            Destroy(gameObject);
        }
    }

}
