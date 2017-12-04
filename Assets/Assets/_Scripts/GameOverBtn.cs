using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//
// C00204076
// Brandon Seah-Dempsey
// Started at 12:14 1 December 2017
// Finished at 12:26 1 December 2017
// Time taken: 12 Minutes
// Known bugs: None

public class GameOverBtn : MonoBehaviour
{
    //
    public void ReplayBtn(string replayLevel)
    {
        SceneManager.LoadScene(replayLevel);
    }

    //
    public void ReplayTwoBtn(string replayLevel)
    {
        SceneManager.LoadScene(replayLevel);
    }

    //
    public void MainBtn(string mainMenu)
    {
        SceneManager.LoadScene(mainMenu);
    }

    //
    public void QuitBtn()
    {
        Application.Quit();
    }
}
