using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    private float force;


    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position; // it commeds the bullet to go to the mouse 
        Vector3 rotaion = transform.position - mousePos; // rotates with the mouse
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotaion.y, rotaion.x) * Mathf.Rad2Deg; // this  controlees the rotaion
        transform.rotation = Quaternion.Euler(0, 0, rot + 90 ); // this contorlles the rotation

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
