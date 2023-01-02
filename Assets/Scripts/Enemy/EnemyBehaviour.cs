using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip clip;
    private PointManager pointManager;
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the other object is the projectile by its tag
        if (collision.tag == "Laser")
        {
           

            // Allows playing an audio clip even if the Alien is destroyed and removed from the scene
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);

            pointManager.UpdateScore(1);

            // Destroy the Alien game object (the one this script is on)
            Destroy(gameObject);

            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // Destroy the projectile game object
            Destroy(collision.gameObject);
        }
    }
}
