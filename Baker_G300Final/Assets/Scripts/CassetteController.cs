using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteController : MonoBehaviour
{
    public int[] inventory = { 0, -1,-1, -1, -1, -1, -1, -1, -1, -1 }; //this is the inventory that keeps track of where the songs are
    public int currentSong = 0;  //this is the current song that is playing
    int numberOfCassettes = 1;  //this is the number of cassettes collected. used to add more songs to the inventory
    public AudioClip[] songs;  //the array of the songs. the number in teh inventory array correspond to the index in this array
    public static CassetteController CC;
    private AudioSource walkman;
    public void addCassette(int cassetteNumber)
    {
        inventory[numberOfCassettes] = cassetteNumber; //add the cassette to the next open spot in the array
        numberOfCassettes += 1;  //add one to the total number of cassettes 
    }

    private void Awake()
    {
        if (CC==null)
        {
            CC = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    private void Start()
    {
        walkman = this.gameObject.GetComponent<AudioSource>();
        walkman.clip = songs[0];
        walkman.Play();  //play the first song at the start of the game
        currentSong = inventory[0];     //make sure the correct song is the currentSong
    }

    private void Update()
    {
      /*  if(Input.GetKeyUp("0") && inventory[9] >= 0) //if the input of the player matcxhes a spot in the inventory that has a cassette
        {
            songs[currentSong].Stop(); //then stop the current song
            currentSong = inventory[9]; 
            songs[currentSong].Play();  //and play the next song
        }
        else if (Input.GetKeyUp("1") && inventory[0] >= 0) //the same as the last statement. important to note the index are off by 1
        {                                                  //this is because the keyboard numbers are ordered   1234567890
            songs[currentSong].Stop();                     //but the array is set up like                       0123456789
            currentSong = inventory[0];                    // by offsetting, the layout of each matches up
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("2") && inventory[1] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[1];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("3") && inventory[2] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[2];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("4") && inventory[3] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[3];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("5") && inventory[4] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[4];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("6") && inventory[5] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[5];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("7") && inventory[6] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[6];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("8") && inventory[7] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[7];
            songs[currentSong].Play();
        }
        else if (Input.GetKeyUp("9") && inventory[8] >= 0)
        {
            songs[currentSong].Stop();
            currentSong = inventory[8];
            songs[currentSong].Play();
        }*/
    }
}
