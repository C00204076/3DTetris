using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

//
// C00204076
// Brandon Seah-Dempsey
// Started at 17:51 3 December 2017
// Finished at 18:02 3 December 2017
// Time taken: 11 Minutes
// Known bugs: None

public class LevelIndex : MonoBehaviour
{
    //
    public Text levelText;
    //
    int levelIndex;
    //
    Scene currentScene;

	// Use this for initialization
	void Start ()
    {
        levelIndex = 1;
        levelText.text = "Level: " + levelIndex;
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentScene = SceneManager.GetActiveScene();

        //
        if (currentScene.name == "3DTetris")
        {
            levelIndex = 1;
        }
        //
        else if (currentScene.name == "Level2")
        {
            levelIndex = 2;
        }

        //
        levelText.text = "Level: " + levelIndex;
    }


}
