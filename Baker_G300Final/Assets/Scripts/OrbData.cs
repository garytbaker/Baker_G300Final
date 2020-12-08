using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbData : MonoBehaviour
{
    public int orbNumber = 0;  //the number of the orb

    private void Start()
    {
        if (CassetteController.CC.orbs[orbNumber] == true) //if the orb has been collected
        {
            gameObject.SetActive(false); //do not respawn
        }
    }
}
