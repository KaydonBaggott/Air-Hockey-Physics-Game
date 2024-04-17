using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        AiScore, PlayerScore
    }

    public TextMeshProUGUI AiScoreTxt, PlayerScoreTxt;

    public UiManager uiManager;

    public int MaxScore;

    #region Scores
    private int aiScore, playerScore;

    private int AiScore
    {
        get { return aiScore; }
        set
        {
            aiScore = value;
            if (value == MaxScore)
                uiManager.ShowRestartCanvas(true); 
        }

    }

    private int PlayerScore
    {
        get { return playerScore; }
        set
        {
            playerScore = value;
            if (value == MaxScore)
                uiManager.ShowRestartCanvas(false);
        }

    }
    #endregion

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoreTxt.text = (++AiScore).ToString();
        else
            PlayerScoreTxt.text = (++PlayerScore).ToString();
    }

    public void ResetScores()
    {
        AiScore = 0;
        AiScoreTxt.text = PlayerScoreTxt.text = "0";

        PlayerScore = 0;
        PlayerScoreTxt.text = PlayerScoreTxt.text = "0";
    }
}