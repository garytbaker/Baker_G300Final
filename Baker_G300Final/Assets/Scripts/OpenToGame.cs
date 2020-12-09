using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenToGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))  //press escape to end the game.
        {
            Application.Quit();
        }
        if (Input.anyKeyDown)  //if any key is pressed start teh game
        {
            SceneManager.LoadScene(1);
        }
    }
}
