using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Screen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void Restart() {
        SceneManager.LoadScene("Level1");
    }    
}
