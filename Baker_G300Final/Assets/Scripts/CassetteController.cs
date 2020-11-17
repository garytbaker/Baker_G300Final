using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteController : MonoBehaviour
{
    public int[] inventory = { 0, -1,-1, -1, -1, -1, -1, -1, -1, -1 };
    public int currentSong = 0;
    public bool needsToSwitch = false;
    int numberOfCassettes = 1;
    public AudioSource[] songs;
    public void addCassette(int cassetteNumber)
    {
        inventory[numberOfCassettes] = cassetteNumber;
        numberOfCassettes += 1;
    }

    private void Start()
    {
        songs[inventory[0]].Play();
        currentSong = inventory[0];
    }

    private void Update()
    {
        if(Input.GetKeyUp("0") && inventory[9] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[9];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("1") && inventory[0] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[0];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("2") && inventory[1] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[1];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("3") && inventory[2] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[2];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("4") && inventory[3] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[3];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("5") && inventory[4] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[4];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("6") && inventory[5] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[5];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("7") && inventory[6] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[6];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("8") && inventory[7] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[7];
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKeyUp("9") && inventory[8] >= 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = inventory[8]; 
            songs[inventory[currentSong]].Play();
        }
    }
}
