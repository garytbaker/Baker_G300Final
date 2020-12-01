using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteController : MonoBehaviour
{
    public int[] inventory = { -1, -1,-1, -1, -1, -1, -1, -1, -1, -1 }; //this is the inventory that keeps track of where the songs are
    public int currentSong = 0;  //this is the current song that is playing
    int numberOfCassettes = 0;  //this is the number of cassettes collected. used to add more songs to the inventory
    public AudioClip[] songs;  //the array of the songs. the number in teh inventory array correspond to the index in this array
    public static CassetteController CC;
    private AudioSource walkman;
    public UIScript userInterface;


    public bool[] orbs = { false,false };//this is the orb inventory
    public void addCassette(int cassetteNumber)
    {
        inventory[cassetteNumber] = cassetteNumber; //add the cassette to the next open spot in the array
        numberOfCassettes += 1;  //add one to the total number of cassettes
        userInterface.unlockCassette(cassetteNumber);
    }

    public void addOrb(int orbNumber)
    {
        orbs[orbNumber] = true;
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
        addCassette(0);
        walkman = this.gameObject.GetComponent<AudioSource>();
        walkman.clip = songs[0];
        walkman.Play();  //play the first song at the start of the game
        currentSong = inventory[0];     //make sure the correct song is the currentSong
        userInterface.highlightSong(currentSong);
    }

    private void Update()
    {
        if(Input.GetKeyUp("0") && inventory[9] >= 0) //if the input of the player matcxhes a spot in the inventory that has a cassette
        {
            currentSong = inventory[9];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();  //and play the next song
        }
        else if (Input.GetKeyUp("1") && inventory[0] >= 0) //the same as the last statement. important to note the index are off by 1
        {                                                  //this is because the keyboard numbers are ordered   1234567890
                                                           //but the array is set up like                       0123456789
            currentSong = inventory[0];                    // by offsetting, the layout of each matches up
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();  //and play the next song
        }
        else if (Input.GetKeyUp("2") && inventory[1] >= 0)
        {
            
            currentSong = inventory[1];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();  

        }
        else if (Input.GetKeyUp("3") && inventory[2] >= 0)
        {
            
            currentSong = inventory[2];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();

        }
        else if (Input.GetKeyUp("4") && inventory[3] >= 0)
        {
            
            currentSong = inventory[3];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();

        }
        else if (Input.GetKeyUp("5") && inventory[4] >= 0)
        {
          
            currentSong = inventory[4];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();

        }
        else if (Input.GetKeyUp("6") && inventory[5] >= 0)
        {
            
            currentSong = inventory[5];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();

        }
        else if (Input.GetKeyUp("7") && inventory[6] >= 0)
        {
            
            currentSong = inventory[6];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();

        }
        else if (Input.GetKeyUp("8") && inventory[7] >= 0)
        {
          
            currentSong = inventory[7];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();
            ;
        }
        else if (Input.GetKeyUp("9") && inventory[8] >= 0)
        {
            
            currentSong = inventory[8];
            walkman.clip = songs[currentSong];
            userInterface.highlightSong(currentSong);
            walkman.Play();
        }
    }
}
