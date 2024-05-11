using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text myScore;
    int coins;
    public string won;
    public int currentScore
    {
        get
        {
            return coins;
        }
        set { coins = value; myScore.text = currentScore.ToString(); }
    }

    public void IncreaseScore(int score)
    {
        //Debug.Log("yyyyyyyyyyyyyyyy");
        currentScore += score;
        myScore.text = currentScore.ToString();

    }
    public void Winner(int score)
    {
        //int maxScore = 20;
        //if //(score = 20)
        {
            SceneManager.LoadScene(won);
        }
    }

}

