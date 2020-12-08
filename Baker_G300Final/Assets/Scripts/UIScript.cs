using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    public Image[] icons;   //the icons on the UI indicating the songs
    private UIScript ThisUI = null;

    private void Awake()
    {
        if (ThisUI == null) //if there is no signleton CassetteController
        {
            ThisUI = this;//make this the singleton
            DontDestroyOnLoad(gameObject);//make it persitent through scenes
        }
        else
        {
            Destroy(gameObject);//otherwise destroy the cassette controller
            return;
        }
    }


    public void unlockCassette(int cassetteNumber)
    {
        icons[cassetteNumber].gameObject.SetActive(true);  //this puts the icon on the hotbar
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
