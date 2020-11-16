using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteController : MonoBehaviour
{
    public int[] inventory = {1,0,0,0,0,0,0,0,0,0};
    public int currentSong = 0;
    public bool needsToSwitch = false;
    public int numberOfCassettes = 0;
    public void addCassette(int cassetteNumber)
    {
        inventory[numberOfCassettes] = cassetteNumber;
    }

    private void Start()
    {
        
    }
}
