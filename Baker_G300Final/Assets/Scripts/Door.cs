using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioSource openSong;
    public Vector2 newLocation;
    void Update()
    {
        if(openSong.isPlaying)
        {
            moveToNewLocation();
        }
    }

    void moveToNewLocation()
    {

    }
}
