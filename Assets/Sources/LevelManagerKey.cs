using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerKey : MonoBehaviour {

    public GameObject key;

    private void Start()
    {
        key.SetActive(false);
    }

    private void Update()
    {
       
    }


    public void setKeyTrigger(bool gotKey)
    {
        key.SetActive(gotKey);
        Level2Variables.keyTigger = true;
    }

    public void toPause()
    {
        SceneManager.LoadScene("Pause");
    }

    
}
