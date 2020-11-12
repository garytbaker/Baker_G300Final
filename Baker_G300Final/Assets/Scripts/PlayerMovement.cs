using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    public Rigidbody2D playerRigidBody;

    Vector2 movement;

    public CassetteController cassetteController;
  
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
    }

    private void FixedUpdate()
    {
        playerRigidBody.MovePosition(playerRigidBody.position + movement * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.tag);
       if (collision.tag == "Cassette")
        {
            cassetteController.addCassette(collision.gameObject.GetComponent<CassetteData>().cassetteNumber);
            collision.gameObject.SetActive(false);
            print("collided");
        }
    }
}
