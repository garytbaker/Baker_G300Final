using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)  
    {
        if (collision.gameObject.tag == "Player")
        {
            if (CassetteController.CC.orbs[0] == true && CassetteController.CC.orbs[1] == true)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(textDeactivator());
        }
    }

    IEnumerator textDeactivator()
    {
        yield return new WaitForSeconds(1);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
}
