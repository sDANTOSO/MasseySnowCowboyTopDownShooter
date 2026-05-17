using UnityEngine;

public class PointManager : MonoBehaviour
{
       public static PointManager Instance;

    public int currentPoints = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddPoints(int amount)
    {
        currentPoints += amount;
    }

}
