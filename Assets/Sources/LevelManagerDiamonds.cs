using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerDiamonds : MonoBehaviour {

    
    private int diamonds = 0;
    public Text diamondText;
    private int maxDiamonds = 6;
    public LevelGenerator lg;

    private void Start() {
        diamondText.text = "Diamonds: " + diamonds + "/"+ lg.diamonds;
    }

    private void Update() {
        if (diamonds == maxDiamonds) {
            SceneManager.LoadScene("Level Finished");
        }
    }


    public void AddDiamond(int numberOfDiamonds) {
        diamonds = diamonds + numberOfDiamonds;
        diamondText.text = "Diamonds: " + diamonds + "/" + maxDiamonds;
        
    }

    public void toPause() {
        SceneManager.LoadScene("Pause");
    }

}