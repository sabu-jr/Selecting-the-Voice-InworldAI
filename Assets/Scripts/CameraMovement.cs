using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float senX;
    public float senY;

    public Transform orientation;

    private float xRotation;
    private float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxisRaw("Mouse X") * senX * Time.deltaTime;
        float mouseY=Input.GetAxisRaw("Mouse Y") * senY * Time.deltaTime;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.rotation=Quaternion.Euler(xRotation, yRotation,0);
        orientation.rotation = Quaternion.Euler(0,yRotation,0);
    }
}
