using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject CanvasGame;
    public GameObject CanvasRestart;

    [Header("CanvasRestart")]
    public GameObject WinTxt;
    public GameObject LoseTxt;

    [Header("Other")]
    public AudioManager audioManager;

    public ScoreScript scoreScript;

    public PuckScript puckScript;
    public PlayerMovement playerMovement;
    public AiScript aiScript;

    public float countdownTime = 3f;

    public bool CountdownStarted = false; 

    public void StartCountdown()
    {
        if (!CountdownStarted)
        {
            StartCoroutine(CountdownCoroutine());
            CountdownStarted = true;
        }
    }

    private System.Collections.IEnumerator CountdownCoroutine()
    {
        while (countdownTime > 0)
        {
            Debug.Log(countdownTime);
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        Debug.Log("GO!");
    }

    public void ShowRestartCanvas(bool didAiWin)
    {
        Time.timeScale = 0;

        CanvasGame.SetActive(false);
        CanvasRestart.SetActive(true);

        if (didAiWin)
        {
            audioManager.PlayLostGame();
            WinTxt.SetActive(false);
            LoseTxt.SetActive(true);
        }
        else
        {
            audioManager.PlayLostGame();
            WinTxt.SetActive(true);
            LoseTxt.SetActive(false);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        CanvasGame.SetActive(true);
        CanvasRestart.SetActive(false);

        scoreScript.ResetScores();
        puckScript.CenterPuck();
        playerMovement.ResetPosition();
        aiScript.ResetPosition();

        countdownTime = 3f;
        CountdownStarted = false;
        StartCountdown();
    }

    public void ShowMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("menu");
    }
}
