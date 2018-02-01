using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void ToGame() {
        SceneManager.LoadScene("manual");
    }

    public void Exit() {
        Debug.Log("Exit Game");
        Application.Quit();     
    }

}

