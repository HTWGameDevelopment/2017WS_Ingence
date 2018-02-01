using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerPortal: MonoBehaviour {
    public LevelGenerator lg = new LevelGenerator() ;
    public static bool PortalCopy = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            LevelGenerator.levelPart++;
            DeleteAll();
            lg.generateLevel();
        }

    }

    public void DeleteAll()
    {
        int i = 0;
        foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
        {
            if (o.CompareTag("MainCamera") == true)
            {
                continue;
            }
            else if (o.CompareTag("LevelManager") == true)
            {
                continue;
            }
            else if (o.CompareTag("LevelGenerator") == true)
            {
                continue;
            }
            else if (o.CompareTag("Canvas") == true)
            {
                continue;
            }
            else if ( o.CompareTag("Player") == true)
            {
                continue;
            }
            else if ( o.CompareTag("MainPortal") == true)
            {
                if (i == 0)
                {
                    o.SetActive(false);
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
            else
            {
                Destroy(o);
            }
        }
    }

    public void toPause()
    {
        SceneManager.LoadScene("Pause");
    }
}
