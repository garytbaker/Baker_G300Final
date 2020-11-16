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
        currentSong = inventory[0];
    }

    private void Update()
    {
        if(Input.GetKey("0") && inventory[9] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 9;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("1") && inventory[0] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 0;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("2") && inventory[1] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 1;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("3") && inventory[2] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 2;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("4") && inventory[3] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 3;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("5") && inventory[4] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 4;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("6") && inventory[5] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 5;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("7") && inventory[6] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 6;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("8") && inventory[7] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 7;
            songs[inventory[currentSong]].Play();
        }
        else if (Input.GetKey("9") && inventory[8] > 0)
        {
            songs[inventory[currentSong]].Stop();
            currentSong = 8;
            songs[inventory[currentSong]].Play();
        }
    }
}
