using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleDiamonds : MonoBehaviour {

    private int diamondValue = 1;
    private LevelManagerDiamonds gameLevelManager;

    // Use this for initialization
    void Start() {
        gameLevelManager = FindObjectOfType<LevelManagerDiamonds>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.CompareTag("Player")) {
            gameLevelManager.AddDiamond(diamondValue);
            Destroy(gameObject);
        }

    }

    
}
