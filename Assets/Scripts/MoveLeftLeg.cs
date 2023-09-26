using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftLeg : MonoBehaviour
{
    //ref for my rigidbody 
    Rigidbody2D myBody;

    //creates vector to move leg
    Vector3 leftLegMove = new Vector3(-1, 0, 0);

    //creates leg power
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
        //if i press the O key
        if (Input.GetKey(KeyCode.O))
        {
            //and push up my leg
            myBody.AddForce(leftLegMove * leftLegPower, ForceMode2D.Impulse);
        }
    }
}
