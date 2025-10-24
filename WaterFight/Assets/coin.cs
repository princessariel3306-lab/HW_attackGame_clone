using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class coin : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreField;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision) // if taged with bread destory
    {
        if (collision.gameObject.name == "bread")
        {
            Debug.Log("colliding with player");
            Destroy(collision.gameObject);


            score += 100;
            scoreField.text = "Score:" + score; //will count score }
        }
        if (collision.gameObject.name == "Fish")
        {
            Debug.Log("colliding with player");
            Destroy(collision.gameObject);


            score += 200;
            scoreField.text = "Score:" + score; //will count score }
        }
    }
}