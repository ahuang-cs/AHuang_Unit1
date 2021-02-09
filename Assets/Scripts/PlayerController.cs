using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Input Sensitivity")]
    public float accelerateSpeed = 15.0f;
    public float turnSpeed = 30.0f;

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);

        // handle accelerator
        transform.Translate(Vector3.forward * Time.deltaTime * accelerateSpeed * verticalInput);

        // handle turning about Y-axis or Vector3.up
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
