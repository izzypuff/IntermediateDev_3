using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    //allows access to win scene
    private string Win = "Win";
    //allows access to lose scene
    private string Lose = "Lose";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //on trigger collision
    void OnTriggerEnter2D(Collider2D collision)
    {
        //if collides with water object
        if(collision.gameObject.name == "Water")
        {
           //load win scene
           SceneManager.LoadScene(Win);
        }
    }

    //on collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if collides with ground object
        if (collision.gameObject.name == "Ground")
        {
            //load lose scene
            SceneManager.LoadScene(Lose);
        }
    }
}