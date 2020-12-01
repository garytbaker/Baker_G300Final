using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    public Image[] icons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unlockCassette(int cassetteNumber)
    {
        icons[cassetteNumber].gameObject.SetActive(true);
    }

    public void highlightSong( int cassetteNumber)
    {
        for(int i =0; i < 10; i++) 
        {
            icons[i].color = Color.grey;
        }
        icons[cassetteNumber].color = Color.white;
    }
}
