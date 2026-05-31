using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //public int pointsToWin = 100;

    public GameObject endScreenPanel;
    public TextMeshProUGUI endScreenText;

    private bool gameEnded = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        endScreenPanel.SetActive(false);
    }

    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        if (SnakeDamage.Instance.currentHealth <= 0f)
        {
            WinGame();
        }
        // if (PointManager.Instance.currentPoints >= pointsToWin)//change to when snake dies
        // {
            
        // }
    }

    public void WinGame()
    {
        gameEnded = true;
        endScreenPanel.SetActive(true);
        endScreenText.text = "You Win";
    }

    // public void LoseGame()
    // {
    //     gameEnded = true;// lose impossible for now, but will be implemented in the future when player health is added
    //     endScreenPanel.SetActive(true);
    //     endScreenText.text = "You Lose";
    // }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}


