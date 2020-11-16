using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteController : MonoBehaviour
{
    public int[] inventory = { 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    public int currentSong = 0;
    public bool needsToSwitch = false;
    public int numberOfCassettes = 0;
    public AudioSource[] songs;
    public void addCassette(int cassetteNumber)
    {
        inventory[numberOfCassettes] = cassetteNumber;
    }

    private void Start()
    {
        songs[inventory[0]].Play();
    }
}
