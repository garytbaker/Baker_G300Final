using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioSource openSong;
    public Vector2 newLocation;
    public int doorSpeed;
    public Rigidbody2D thisRB;

    bool opened = false;
    void Update()
    {
        if(openSong.isPlaying)
        {
            opened = true;
        }
    }

    private void FixedUpdate()
    {
        if (opened == true)
        {
            thisRB.MovePosition(newLocation);
        }
    }
}
