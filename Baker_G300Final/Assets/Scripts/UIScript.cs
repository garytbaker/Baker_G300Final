using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    public Image[] icons;   //the icons on the UI indicating the songs
    private UIScript ThisUI = null;
    public Image hotbar;

    private void Awake()
    {
        if (ThisUI == null) //if there is no signleton UIScript
        {
            ThisUI = this;//make this the singleton
            DontDestroyOnLoad(gameObject);//make it persitent through scenes
        }
        else
        {
            Destroy(gameObject);//otherwise destroy the other UIScript
            return;
        }
    }


    public void unlockCassette(int cassetteNumber)
    {
        icons[cassetteNumber].gameObject.SetActive(true);  //this puts the icon on the hotbar
    }

    public void turnOnHotBar()
    {
        hotbar.gameObject.SetActive(true);  //this turns on teh base hotbar image. had to do this because if it is initial set to active, then when you go to the center a new hotbar gets redrawn over the previous one makeing the icons seem to fade away.
    }
    public void highlightSong( int cassetteNumber)
    {
        for(int i =0; i < 10; i++) //for every icon
        {
            icons[i].color = new Color(.6f,.6f,.6f,1);//set its color to grey
        }
        icons[cassetteNumber].color = Color.white; //then highlight the one that is playing by turning it white
    }
}
