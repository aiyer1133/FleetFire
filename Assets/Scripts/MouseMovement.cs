using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float senstivity;
    float xRotation = 0f;
    
    public Transform playerBody;
    public float TopClamp = -70f;
    public float BottomClamp = 70f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * senstivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * senstivity * Time.deltaTime;
//for rotating camera up mouse goes down
        
        xRotation -= mouseY;
        //limit to looking up and down 
        xRotation = Mathf.Clamp(xRotation, TopClamp, BottomClamp);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
       
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
