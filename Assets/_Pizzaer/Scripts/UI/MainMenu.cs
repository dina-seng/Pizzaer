using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject storyPanel;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1f;
        titlePanel.SetActive(true);
        storyPanel.SetActive(false);
    }

    // Button: Play (on title panel) -> show the story
    public void OnPlay()
    {
        titlePanel.SetActive(false);
        storyPanel.SetActive(true);
    }

    // Button: Start (on story panel) -> load the town
    public void OnStartGame()
    {
        SceneManager.LoadScene("Town");
    }

    // Button: Quit (works only in a build, not in the Editor)
    public void OnQuit()
    {
        Application.Quit();
    }
}
