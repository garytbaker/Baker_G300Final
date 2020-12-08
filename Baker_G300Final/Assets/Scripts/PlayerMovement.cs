using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;  //the move speed of the player

    public Rigidbody2D playerRigidBody;  //the players rigidbody

    Vector2 movement;  //the movement the player needs

  
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
