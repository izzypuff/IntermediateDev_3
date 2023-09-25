using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightArm : MonoBehaviour
{
    //ref for my rigidbody that is on my arm
    Rigidbody2D myBody;

    public float rightArmPower;

    Vector3 rightArmMove = new Vector3(-1, 0, 0);

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
        if (Input.GetKey(KeyCode.W))
        {
            //and push up my arm
            myBody.AddForce(rightArmMove * rightArmPower, ForceMode2D.Impulse);
        }
    }
}
