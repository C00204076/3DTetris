using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using UnityEngine;

//
// C00204076
// Brandon Seah-Dempsey
// Started at 18:18 3 December 2017
// Finished at
// Time taken:
// Known bugs:

public class FileLoading : MonoBehaviour
{
    //
    public Text hi_score;
    //
    public TextAsset textFile;

    private int hi_Score;
    string file, fileText;

    // Use this for initialization
    void Start ()
    {
        file = textFile.text;
        updateBest();
    }
	
	// Update is called once per frame
	void Update ()
    {
        updateBest();
    }

    //
    public int Hi_Score
    {
        get
        {
            return hi_Score;
        }

        set
        {
            hi_Score = value;
        }
    }

    //
    void updateBest()
    {
        hi_Score = int.Parse(file);
        hi_score.text = "Best Score: " + hi_Score;
    }

    //
    public void overwriteHiScore()
    {

    }
}
