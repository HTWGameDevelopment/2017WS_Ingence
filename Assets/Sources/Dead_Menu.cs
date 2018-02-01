using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead_Menu : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToGame() {
        SceneManager.LoadScene("Level" + LevelGenerator.levelnumber);
    }

    public void ToMenu() {
        SceneManager.LoadScene("Menu");
    }
}
