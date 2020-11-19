using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioClip rightSong; //the song for the door to open for
    public Vector3 newLocation = new Vector3(0,0,0); //this is the new location for the door to go to when opened
    public int doorSpeed;  //how fast the door should open
    public GameObject player;  //reference to the player
    public int openSongDistance;  //the distance the player can be wehn playing the song for the door to open

    bool opening = false;  //if the door should be opening
    bool opened = false;  //if the door is at its destination
    void Update()
    {       //if the right song is playing and the player is close enough(sqr magnitude is to account for a negative vector)
        if(CassetteController.CC.GetComponent<AudioSource>().clip ==  rightSong && (player.transform.position-transform.position).sqrMagnitude < openSongDistance)
        {
            opening = true; //the door should be opening
        }
    }

    private void FixedUpdate()
    {       //if the door should be opening and the door has not reached its destination
        if (opened == false && opening ==true)
        {
            transform.position = Vector3.MoveTowards(transform.position,newLocation,Time.deltaTime*doorSpeed); //move the door towards its destination
            if (transform.position == newLocation) //if it is at the new destination
            {
                opened = true;  //it is opened
            }
        }
    }
}
