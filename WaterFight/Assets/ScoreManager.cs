using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI Goose;
    public TextMeshProUGUI Duck;

    public int duck = 0;
    public int goose = 0;
    public int breadCount = 8;
    public int fish = 1;
    public GameObject breadprfab;
    public GameObject fishprfab;
    public float PlayerTurnTime = 0f;
    
    void Start()
    {
        Debug.Log("Bread Count" + breadCount);
        UpdateScore();
       // Updatebreadcount();

    }
     void Update()
    {
        if (PlayerTurnTime > 0f)
        {
            PlayerTurnTime -= Time.deltaTime;
            Debug.Log(PlayerTurnTime);

            //- timdelta.time dew from timer vale
            //check if value is  <= 0 
            //if it is spawn 1 fish in a random locason 
            if (PlayerTurnTime <= 0)
            {
                GameObject fish  = Instantiate (fishprfab);
                fish.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 3), 0); 
            }
        }
        
    }
    public void IncrementPlayer1Score(int points)
    {
        duck += points;
        UpdateScore();

    }

    public void IncrementPlayer2Score(int points)
    {
        goose += points;
        UpdateScore();
    }

    void UpdateScore()
    {
        Duck.text = "Duck: " + duck.ToString();
        Goose.text = "Goose: " + goose.ToString();
    }

    public void Updatebreadcount()
    {
        Debug.Log(breadCount);
        breadCount -= 1;
        if (breadCount <= 0)
        {

            for (int y = 0; y < 8; y++)
            {
                GameObject bread = Instantiate(breadprfab);
                bread.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 3), 0);
            }
            breadCount = 8;
        }
        else
        {
            Debug.Log("we are not breaking more bread");
        }





    }
    public void UpdateFish()
    {
        // i nned to start the timer set it to five 
        PlayerTurnTime = 5f;
      //  fish -= 1;
      //if (fish <= 0)
      //{

      //    for (int y = 0; y < 1; y++)
      //   {
      //        Debug.Log("fish");
      //        GameObject fish = Instantiate(fishprfab);
      //         fish.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 3), 0);
      //    }
      //     fish = 1;
      //  }
      //  else
      //  {
      //      Debug.Log("just keep swiming ");
      //  }
    }
    public void PlayerTimer() // this makes a timer 
    {
        if (PlayerTurnTime > 0)
            PlayerTurnTime -= Time.deltaTime;
        
        //creat a timer verabel and set it to zero
        // when i toch a fisg]h i want it to sewt to 10
        // check if the vealu of the timer is greater then 0 
        // make it go down 
        // call fish 

    }
}
