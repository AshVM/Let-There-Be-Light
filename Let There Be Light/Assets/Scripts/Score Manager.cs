using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int currentScore;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;


    public void ChangeScore(int points)
    {
        currentScore += points;
        scoreText.text = currentScore.ToString();
    }

    public void HighScoreUpdate()
    {
        //is there already a highscore?
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            // is new score higher than saved score?
            if (currentScore > PlayerPrefs.GetInt("SavedHighScore"))
            {
                //set new highscore
                PlayerPrefs.SetInt("SavedHighScore", currentScore);
            }
        }
        else
        {
            //if no highscore set the highscore
            PlayerPrefs.SetInt("SavedHighScore", currentScore);
        }

        // updating our tmp text
        finalScoreText.text = currentScore.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
