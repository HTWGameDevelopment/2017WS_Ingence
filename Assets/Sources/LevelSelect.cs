using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	public void toLevel1()
    {
        SceneManager.LoadScene("Level1");
        LevelGenerator.levelnumber = "1";
    }

    public void toLevel2()
    {
        SceneManager.LoadScene("Level2");

        LevelGenerator.levelnumber = "2";
    }

    public void toLevel3()
    {
        SceneManager.LoadScene("Level3");

        LevelGenerator.levelnumber = "3";
    }

    public void back()
    {
        SceneManager.LoadScene("Menu");
    }
}
