using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm1 : MonoBehaviour
{

    Rigidbody2D myBody;

    float armPower = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            myBody.AddForce(transform.up * armPower, ForceMode2D.Impulse);
        }
    }
}
