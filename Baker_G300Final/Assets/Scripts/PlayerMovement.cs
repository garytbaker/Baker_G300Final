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
        if (Input.GetKey("space"))
        {
            print("here");
            SceneManager.LoadScene(1);
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
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            collision.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            
            //collision.gameObject.SetActive(false); //remove the cassette from the scene
        }
       if(collision.tag == "Orb")
        {
            CassetteController.CC.addOrb(collision.gameObject.GetComponent<OrbData>().orbNumber);
            collision.gameObject.SetActive(false);
        }
    }
}
