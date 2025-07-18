using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 10f;

    public float horizontalValue;
    public float verticalValue;

    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalValue = Input.GetAxis("Horizontal" + inputID);
        verticalValue = Input.GetAxis("Vertical" + inputID);

        //move forward
        //Time.deltaTime (built-in function) is per second
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalValue);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalValue);

    }
}
