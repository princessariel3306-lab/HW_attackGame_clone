using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI seaweed;
    public int Boueycount;
    public  static  scoreManager instance;
    public int duckfloaty = 0;

    // Start is called before the first frame update

    void Start()
    {
        
       
 
    }
    void Update()
    {
      
    }

   public void UpdateScore()
    {
        seaweed.text = "" + duckfloaty.ToString();
        duckfloaty += 1;
    }
    private void Awake()
    {
        if (instance !=  null && instance != this  ) 
        { 
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }


}

