using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject DifficultyToggles;

    public void PlayGame()
    {
        SceneManager.LoadScene("main");
    }

    #region Difficulty
    public void SetEasyDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Easy;
    }

    public void SetMediumDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Medium;
    }

    public void SetHardDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Hard;
    }
    #endregion
}
