using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    GameObject CompleteLevel;

    GameObject pauseLevel;

    GameObject DethPanel;

    GameObject GamePanel;

    private void Start()
    {
        DethPanel = GameObject.FindGameObjectWithTag("DethPanel");
        CompleteLevel = GameObject.FindGameObjectWithTag("CompleteLevel");
        pauseLevel = GameObject.FindGameObjectWithTag("PauseMenu");
        GamePanel = GameObject.FindGameObjectWithTag("GamePanel");
        DethPanel.SetActive(false);
        CompleteLevel.SetActive(false);
        pauseLevel.SetActive(false);
        GamePanel.SetActive(true);
    }

    public void completeLevel ()
    {
        CompleteLevel.SetActive(true);
        GamePanel.SetActive(false);
    }
    public void PauseLevel ()
    {
        pauseLevel.SetActive(true);
        GamePanel.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ResumeLevel()
    {
        pauseLevel.SetActive(false);
        GamePanel.SetActive(true);
        Time.timeScale = 1f;
    }

    public void EndGame ()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("game over");
            Deth();
            GamePanel.SetActive(false);
        }
    }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Deth ()
    {
        DethPanel.SetActive(true);
    }
    public void ToMap ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void ToStore ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        Time.timeScale = 1f;
    }
    public void GoToMainMenu ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
