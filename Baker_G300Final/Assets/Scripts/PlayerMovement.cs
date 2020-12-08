using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;  //the move speed of the player

    public Rigidbody2D playerRigidBody;  //the players rigidbody

    Vector2 movement;  //the movement the player needs

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if(CassetteController.CC.previousLevel == 2)
            {
                gameObject.transform.position = new Vector3(-8.28999996f, -2.82999992f, 0);
            }
            if (CassetteController.CC.previousLevel == 4)
            {
                gameObject.transform.position = new Vector3(2.75999999f, -3.3900001f, 0);
            }
            if (CassetteController.CC.previousLevel == 3)
            {
                gameObject.transform.position = new Vector3(7.78999996f, 1.72000003f, 0);
            }
            if (CassetteController.CC.previousLevel == 8)
            {
                gameObject.transform.position = new Vector3(3.57999992f, 3.00999999f, 0);
            }
            if (CassetteController.CC.previousLevel == 7)
            {
                gameObject.transform.position = new Vector3(-4.73999977f, 3.00999999f, 0);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (CassetteController.CC.previousLevel == 1)
            {
                gameObject.transform.position = new Vector3(8.60999966f, -1.66999996f, 0);
            }
            if (CassetteController.CC.previousLevel == 6)
            {
                gameObject.transform.position = new Vector3(-7.78999996f, 3.56999993f, 0);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (CassetteController.CC.previousLevel == 1)
            {
                gameObject.transform.position = new Vector3(-8.85000038f, -3.36999989f, 0);
            }
            if (CassetteController.CC.previousLevel == 5)
            {
                gameObject.transform.position = new Vector3(7.5999999f, 1.69000006f, 0);
            }
        }
        CassetteController.CC.previousLevel = SceneManager.GetActiveScene().buildIndex;
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");  //getting input from the player
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();                           //normalizing it so the player goes the same speed in all directions
        if (Input.GetKey(KeyCode.Escape))  //press escape to end the game.
        {
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        playerRigidBody.MovePosition(playerRigidBody.position + movement * moveSpeed * Time.deltaTime); //moves the player based speed and input
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Cassette")                 //if the player collides with a cassette
        {
            CassetteController.CC.addCassette(collision.gameObject.GetComponent<CassetteData>().cassetteNumber);  //add the cassette to the inventory
            collision.gameObject.transform.GetChild(1).gameObject.SetActive(true);//turn on the collected text
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);//turn off the cassette sprite
            
            StartCoroutine(objectDeactivator(collision.gameObject));//tun off the text after one sec using a coroutine
        }
       if(collision.tag == "Orb")
        {
            CassetteController.CC.addOrb(collision.gameObject.GetComponent<OrbData>().orbNumber);  //add the orb to the inventory
            collision.gameObject.transform.GetChild(1).gameObject.SetActive(true);//turn on the collected text
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);//turn off the orb sprite
            StartCoroutine(objectDeactivator(collision.gameObject)); //turn off the collected text after one second using coroutine
        }
    }

    IEnumerator objectDeactivator(GameObject obj)  //this is a coroutine that will wait one second the set the active of the object to off
    {
        yield return new WaitForSeconds(1); //wait one second
        obj.SetActive(false); //remove the object from the scene
    }
}
