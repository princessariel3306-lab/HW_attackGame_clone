using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Duck : MonoBehaviour
{
 




    public ScoreManager scoreManager; // Reference to the ScoreManager script

    public void OnScore()
    {
        scoreManager.IncrementPlayer2Score(10); // Example: Player 1 scores 10 points
    }
    private float speed = 6;
    private float xVelocity;
    private float yVelocity;
    public Rigidbody2D rb;
    public int score = 0;
    public TextMeshProUGUI scoreField;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = MovePlayer();
    }
    public Vector2 MovePlayer()//this is the coode to move the player 
    {
        Vector2 input = rb.velocity;

        if (Input.GetKey(KeyCode.W)) //when you i you will go up 
        {
            input.y = speed;
        }
        else if (Input.GetKey(KeyCode.S)) //when you press k you will down
        {
            input.y = -speed;
        }
        else
        {
            input.y = 0;
        }

        if (Input.GetKey(KeyCode.A))//when you press j you will go left
        {
            input.x = -speed;
        }
        else if (Input.GetKey(KeyCode.D)) //when you press l you will go right
        {
            input.x = speed;
        }
        else
        {
            input.x = 0;
        }

        return input; // this will stop you 
    }
    private void OnTriggerEnter2D(Collider2D collision) // if taged with bread destory //eat code
    {
        if (collision.gameObject.name == "bread" || collision.gameObject.name == "Target(Clone)")// if touch it will go away 
        {
            OnScore();
            Destroy(collision.gameObject);
            scoreManager.Updatebreadcount();
        }
        if (collision.gameObject.name == "fish" || collision.gameObject.name == "fish(Clone)")// if touch it will go away 
        {
            OnScore();
            Destroy(collision.gameObject);
            scoreManager.UpdateFish();

        }
    }


   
}


