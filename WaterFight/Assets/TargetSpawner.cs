using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private GameObject TargetPrefab;
    [SerializeField] private Sprite[] targetSprite;
    [SerializeField] private BoxCollider2D cd;
    [SerializeField] private float cooldown;
    private float timer = 10f;
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject newTarget = Instantiate(TargetPrefab);
            timer = cooldown;
            float randomx = Random.Range(cd.bounds.min.x,cd.bounds.max.x);  
            newTarget.transform.position = new Vector2(randomx, transform.position.y);
            newTarget.GetComponent<SpriteRenderer>().sprite = targetSprite[Random.Range(0, targetSprite.Length)];

        }
    }
}
