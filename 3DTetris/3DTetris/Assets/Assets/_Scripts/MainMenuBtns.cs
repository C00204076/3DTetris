using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//
// C00204076
// Brandon Seah-Dempsey
// Started at 14:07 30 November 2017
// Finished at 14:23 30 November 2017
// Time taken: 16 Minutes
// Known bugs: None


public class MainMenuBtns : MonoBehaviour
{
    //
    public void PlayGameBtn(string playGameLevel)
    {
        SceneManager.LoadScene(playGameLevel);
    }

    //
    public void PlayTwoGameBtn(string playGameLevel)
    {
        SceneManager.LoadScene(playGameLevel);
    }

    //
    public void QuitGameBtn()
    {
        Application.Quit();
    }
}
