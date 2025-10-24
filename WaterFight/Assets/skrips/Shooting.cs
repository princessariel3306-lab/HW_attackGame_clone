using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFireing;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();//set a camera incase we have two cameras
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);//set vecoore three to corser
        Vector3 rotaion = mousePos - transform.position; 
        float rotZ = Mathf.Atan2(rotaion.y, rotaion.x) * Mathf.Rad2Deg; // this  controlees the rotaion
        transform.rotation = Quaternion.Euler(0,0,rotZ); // this contorlles the rotation
        if (!canFire)// set the timer so you can fire again
        {
            timer += Time.deltaTime; 
            if (timer > timeBetweenFireing)
            {
                canFire = true;
                timer = 0;
            
            }

        
        }
        if (Input.GetMouseButton(0)&& canFire) // make it so you can fire 
        {
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
            canFire = false;
        }
    }
}

