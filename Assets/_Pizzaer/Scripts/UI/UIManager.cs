using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// Shows everything on screen in the Town scene. Lives on UI_Canvas.
public class UIManager : MonoBehaviour
{
    [Header("HUD")]
    public TMP_Text moneyText;
    public TMP_Text orderText;
    public GameObject promptPanel;      // "Press E"

    [Header("Dialogue")]
    public GameObject dialoguePanel;
    public TMP_Text speakerText;
    public TMP_Text lineText;
    public float dialogueSeconds = 3f;

    [Header("Win")]
    public GameObject winPanel;
    public TMP_Text winMoneyText;

    Coroutine hideRoutine;

    void Awake()
    {
        promptPanel.SetActive(false);
        dialoguePanel.SetActive(false);
        winPanel.SetActive(false);
    }

    public void SetMoney(int amount)
    {
        moneyText.text = "$" + amount;
    }

    public void SetOrder(string text)
    {
        orderText.text = text;
    }

    public void ShowPrompt(bool show)
    {
        promptPanel.SetActive(show);
    }

    // Show a line of dialogue, then hide it after a few seconds.
    public void ShowDialogue(string speaker, string line)
    {
        speakerText.text = speaker;
        lineText.text = line;
        dialoguePanel.SetActive(true);

        if (hideRoutine != null) StopCoroutine(hideRoutine);
        hideRoutine = StartCoroutine(HideDialogueLater());
    }

    IEnumerator HideDialogueLater()
    {
        yield return new WaitForSecondsRealtime(dialogueSeconds);
        dialoguePanel.SetActive(false);
    }

    public void ShowWin(int totalMoney)
    {
        winMoneyText.text = "Shop saved! You earned $" + totalMoney + "!";
        promptPanel.SetActive(false);
        winPanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None; // let the player click buttons
        Cursor.visible = true;
        Time.timeScale = 0f;                     // freeze the game
    }

    // Button: Play Again
    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Town");
    }

    // Button: Main Menu
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
