using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerLives : MonoBehaviour

{

    
    public int lives = 3;
    public Image[] livesUI;
    public GameObject hurtPrefab;
    public AudioClip clip;

    //taastan tulnuka ilmumise koha
    public Vector2 respawnPoint;

    public static bool IsHide = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //lisan funkltsiooni et tulnukas ilmuks taas nähtavale

    public void RespawnNow()
    {
        transform.position = respawnPoint;
    }

    //This I use when planets are going to move and destroy the alien
//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.collider.gameObject.tag == "Enemy")
//        {
//            Destroy(collision.collider.gameObject);
//            Instantiate(hurtPrefab, transform.position, Quaternion.identity);
//            lives -= 1;
//            for (int i = 0; i < livesUI.Length; i++)
//            {
//                if (i < lives)
//                {
//                    livesUI[i].enabled = true;
//                }
//                else
//                {
//                    livesUI[i].enabled = false;
//                }
//            }
//            if (lives <= 0)
//            {
//                Destroy(gameObject);
//
//            }
//        }
//    }

    // mängija kaotab elusid, kui asteroid teda puudutab
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            
           Destroy(collision.gameObject);

            // iga kord kui saad pihta kostub ai
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);
            
            Instantiate(hurtPrefab, transform.position, Quaternion.identity);
            
            RespawnNow();

            lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
             
                SceneManager.LoadScene("GameOver");
            }
        } 
    }
}