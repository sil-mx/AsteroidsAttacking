using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Siin on kood, et asteroid liiguks alla

public class AsteroidBehaviour : MonoBehaviour
{



    public float speed;
    public GameObject asteroidPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
