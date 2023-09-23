using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftLeg : MonoBehaviour
{
    //ref for my rigidbody that is on my arm
    Rigidbody2D myBody;

    Vector3 leftLegMove = new Vector3(-1, 0, 0);

    public float leftLegPower;

    // Start is called before the first frame update
    void Start()
    {
        //set the references
        //just "GetComponent" by itself can access any component on the gameobject this script is on
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i press the A key
        if (Input.GetKeyDown(KeyCode.O))
        {
            //and push up my arm
            myBody.AddForce(leftLegMove * leftLegPower, ForceMode2D.Impulse);
        }
    }
}
