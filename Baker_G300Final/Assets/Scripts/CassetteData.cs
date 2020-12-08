using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteData : MonoBehaviour
{
    public int cassetteNumber = 0;  //the data for which song the cassette holds


    private void Start()
    {
        if (CassetteController.CC.inventory[cassetteNumber] == cassetteNumber) //if the song has already been selected
        {
            gameObject.SetActive(false); //do not respawn
        }
    }
}

