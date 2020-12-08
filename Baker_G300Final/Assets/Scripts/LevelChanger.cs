using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour
{
    public int ToLevel;   //this is the build index for the scene we want to change to.


    private void OnTriggerEnter2D(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(ToLevel);
        }
    }

}
