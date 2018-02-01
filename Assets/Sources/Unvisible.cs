using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unvisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.CompareTag("Player")) {
            gameObject.SetActive(false);
        }

    }
}
