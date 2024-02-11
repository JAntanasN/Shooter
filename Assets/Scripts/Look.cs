using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{

    public Transform cam;

    private float xRotation = 0;
    
    void Start()
    {
        //Mouse can't go out of screen
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        var mouseX = Input.GetAxis("Mouse X");
        var mouseY = Input.GetAxis("Mouse Y");

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        //cam rotates up to down
        cam.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //body rotates left to right
        transform.Rotate(Vector3.up * mouseX);
    }
}
