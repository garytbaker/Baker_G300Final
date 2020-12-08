using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour
{
    public int ToLevel;   //this is the build index for the scene we want to change to.


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") //if the player goes through the door
        {
            SceneManager.LoadScene(ToLevel); //go to the correct level
        }
    }

}
