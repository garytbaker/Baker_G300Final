using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    public Image[] icons;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    public void unlockCassette(int cassetteNumber)
    {
        icons[cassetteNumber].gameObject.SetActive(true);
    }

    public void highlightSong( int cassetteNumber)
    {
        for(int i =0; i < 10; i++) 
        {
            icons[i].color = new Color(.7f,.7f,.7f,1);
        }
        icons[cassetteNumber].color = Color.white;
    }
}
