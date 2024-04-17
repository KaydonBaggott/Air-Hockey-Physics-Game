using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownManager : MonoBehaviour
{
    public TMP_Text countdownText;
    public float countdownDuration = 5f;

    private void Start()
    {
        StartCoroutine(StartGameCountdown());
    }

    private IEnumerator StartGameCountdown()
    {
        float timer = countdownDuration;

        while (timer > 0f)
        {
            countdownText.text = Mathf.Ceil(timer).ToString();
            timer -= Time.deltaTime;
            yield return null;
        }

        // Start the game (load the Main scene)
        SceneManager.LoadScene("Main");
    }
}