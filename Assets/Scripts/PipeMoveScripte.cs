using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScripte : MonoBehaviour
{
    public float PipeMoveSpeed = 5;
    public float deadzone = -50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * PipeMoveSpeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
            Debug.Log("pipe deleted");
        }
         
    }
}
