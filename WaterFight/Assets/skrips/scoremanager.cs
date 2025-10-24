/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public TextMeshProUGUI Goose;
    public TextMeshProUGUI Duck;

    public int duck = 0;
    public int goose = 0;
    public int enemyCount = 8;
    public int fish = 1;
    public GameObject enemyprfab;
    public GameObject fishprfab;
    public float PlayerTurnTime = 0f;

    void Start()
    {
        Debug.Log("Bread Count" + enemyCount);
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
                GameObject fish = Instantiate(fishprfab);
                fish.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 3), 0);
            }
        }

    }
    public void IncrementPlayer1Score(int points)
    {
        duck += points;
        UpdateScore();

    }

   

    void UpdateScore()
    {
        Duck.text = "Duck: " + duck.ToString();
      
    }

    public void Updatebreadcount()
    {
        Debug.Log(enemyCount);
        enemyCount -= 1;
            if (enemyCount <= 0)
            {

            for (int y = 0; y < 8; y++)
            {
                GameObject enmey = Instantiate(enemyprfab);
                enemy.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 3), 0);
            }
            enemyCount = 8;
        }
        else
        {
            Debug.Log("we are not breaking more bread");
        }





    }
}*/
