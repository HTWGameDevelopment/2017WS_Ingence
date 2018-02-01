using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleKey : MonoBehaviour {

   
    private LevelManagerKey gameLevelManager;

    // Use this for initialization
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManagerKey>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            gameLevelManager.setKeyTrigger(true);
            Destroy(gameObject);
        }

    }
}
