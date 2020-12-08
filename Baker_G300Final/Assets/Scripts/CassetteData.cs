using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteData : MonoBehaviour
{
    public int cassetteNumber = 0;  //the data for which song the cassette holds


    private void Awake()
    {
        if (CassetteController.CC.inventory[cassetteNumber] != cassetteNumber)
        {
            gameObject.SetActive(true);
        }
    }
}

