using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    private float sensX = 100f;
    private float sensY = 100f;

    public Transform cam;

    float mouseX;
    float mouseY;

    public float multiplier = 0.01f;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        MyInput();

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    public void UpdateSensitivty(Slider s)
    {
        multiplier = s.value;
    }

    private void MyInput()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");

        yRotation += mouseX * multiplier;
        xRotation -= mouseY * multiplier;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


    }

}
