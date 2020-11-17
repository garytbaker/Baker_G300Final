using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioSource openSong;
    public Vector3 newLocation = new Vector3(0,0,0);
    public int doorSpeed;
    public Rigidbody2D thisRB;

    bool opening = false;
    bool opened = false;
    void Update()
    {
        if(openSong.isPlaying)
        {
            opening = true;
        }
    }

    private void FixedUpdate()
    {
        if (opened == false && opening ==true)
        {
            transform.position = Vector3.MoveTowards(transform.position,newLocation,Time.deltaTime*doorSpeed);
            if (transform.position == newLocation)
            {
                opened = true;
            }
        }
    }
}
