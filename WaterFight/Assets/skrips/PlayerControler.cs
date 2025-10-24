using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float movespeed = 6;
    private float xVelocity;
    private float yVelocity;
     public Rigidbody2D rb;
    


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        var xPos = gameObject.transform.position.x;
        var yPos = gameObject.transform.position.y;
        //OpenDoor(); // calls open door 
       
        if (Input.GetKey(KeyCode.W)) // it makes the player go up
        {
            yVelocity += Time.deltaTime * movespeed;

        }

        else if (Input.GetKey(KeyCode.S)) // makr the playert go down
        {
            yVelocity -= Time.deltaTime * movespeed;
        }
        else { yVelocity = 0; }
        if (Input.GetKey(KeyCode.D)) // make the player go right 
        {
            xVelocity += Time.deltaTime * movespeed;
        }

        else if (Input.GetKey(KeyCode.A)) // make the player left
        {
            xVelocity -= Time.deltaTime * movespeed;
        }
        else { xVelocity = 0; }

        xPos = xVelocity;
        yPos = yVelocity;
        rb.velocity = new Vector2(xPos, yPos);
        //gameObject.transform.position = new Vector2(xPos, yPos);
      /*  Debug.Log("Update.");*/
    }
    

}
