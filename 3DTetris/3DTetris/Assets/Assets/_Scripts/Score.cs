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
// Known bugs:


public class Score : MonoBehaviour
{
    //
    public Text score;
    //
    int scoreVal;

	// Use this for initialization
	void Start ()
    {
        scoreVal = 0;
        score.text = "Score : " + scoreVal;
	}
	
	// Update is called once per frame
	void Update ()
    {
        score.text = "Score : " + scoreVal;
    }

    //
    public void addScore(int addedScore)
    {
        scoreVal += addedScore;
        score.text = "Score : " + scoreVal;
    }
}
