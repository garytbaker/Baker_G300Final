using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioSource openSong;
    public Vector3 newLocation = new Vector3(0,0,0);
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
            print("here");
            Vector3.MoveTowards(transform.position,newLocation,Time.deltaTime*doorSpeed);
        }
    }
}
