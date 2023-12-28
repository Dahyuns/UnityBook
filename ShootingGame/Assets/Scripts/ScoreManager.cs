using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;
    public int currentScore;

    public Text bestScoreUI;
    public int bestScore;

    public void SetScore(int value)
    {

    }

    public int GetScore()
    {
        return currentScore;
    }


    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreUI.text = "최고점수 : " + bestScore;    
    }

    void Update()
    {
    }
}
