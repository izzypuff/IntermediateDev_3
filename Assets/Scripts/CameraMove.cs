using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //creates variable for player
    public GameObject Player;

    //creates variable for speed
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creates variable for camera speed based on frames in game
        float cameraSpeed = speed * Time.deltaTime;

        //creates a vector for the position
        Vector3 position = this.transform.position;
        //creates lerp for y pos
        position.y = Mathf.Lerp(this.transform.position.y, Player.transform.position.y, cameraSpeed);
        //creates lerp for x pos
        position.x = Mathf.Lerp(this.transform.position.x, Player.transform.position.x, cameraSpeed);

        //applies the position to the transform of this object
        this.transform.position = position;
    }
}
