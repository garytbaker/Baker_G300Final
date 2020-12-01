using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)  //this is for detecting collisions
    {
        if (collision.gameObject.tag == "Player") //if the player touches the portal
        {
            if (CassetteController.CC.orbs[0] == true && CassetteController.CC.orbs[1] == true) //and he collected both of the orbs
            {
                SceneManager.LoadScene(2); //go to the win screen
            }
            else
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(true);  //otherwise tell the player they need to collect the orbs
            }
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //when the player leaves the porta
        {
            StartCoroutine(textDeactivator());  //wait one second and then remove the text from the screen using coroutines
        }
    }

    IEnumerator textDeactivator()
    {
        yield return new WaitForSeconds(1); //wait one second
        gameObject.transform.GetChild(1).gameObject.SetActive(false);//remove the text from the screen
    }
}
