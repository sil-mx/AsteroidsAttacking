using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Siia peab tulema kood, et kui mängija saab asteroidiga pihta,
// siis saab mäng läbi.

public class PlayerBehaviour : MonoBehaviour
{
    public AudioClip clip;
    public GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);

            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }

}
