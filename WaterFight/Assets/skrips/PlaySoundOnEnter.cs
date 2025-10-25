using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnter : MonoBehaviour
    
{
    AudioSource source;
    Collider2D soundTrigger; //takeother clooders

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.Play();// it make the sound play when you enter but you need to meention the source or the sound trigger
    }
    void Awake() //  this is the part you need to compleat the top of the code to get it to play 
    {
        source = GetComponent<AudioSource>(); 
        soundTrigger = GetComponent<Collider2D>();
    }
}
