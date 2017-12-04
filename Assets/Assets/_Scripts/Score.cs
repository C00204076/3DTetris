using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//
//
// C00204076
// Brandon Seah-Dempsey
// Started at 12:11 20 November 2017
// Finished at
// Time taken:
// Known bugs:


public class Score : MonoBehaviour
{
    //
    public Text score;
    //
    private int scoreVal;

	// Use this for initialization
	void Start ()
    {
        scoreVal = 0;
        updateScore();
    }
	
	// Update is called once per frame
	void Update ()
    {
        updateScore();
    }

    //
    public void addScore(int addedScore)
    {
        scoreVal += addedScore;
        updateScore();
    }

    //
    /*public int getScore()
    {
        return scoreVal;
    }*/

    //
    void updateScore()
    {
        score.text = "Score : " + scoreVal;
    }

    //
    public int ScoreVal
    {
        get
        {
            return scoreVal;
        }

        set
        {
            scoreVal = value;
        }
    }
}
