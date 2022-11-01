using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab4_03_Camera : MonoBehaviour
{
    public Transform player;
    private float sensitivity = 400f;
    private float yRotation = 0.0f;
    private float xRotation = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation += mouseXMove;

        yRotation -= mouseYMove;
        yRotation = Mathf.Clamp(yRotation,-90f,90f);

        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // a dla osi X obracamy kamerę dla lokalnych koordynatów
        // -mouseYMove aby uniknąć ofektu mouse inverse
        transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
        transform.rotation = Quaternion.Euler(yRotation,xRotation,0.0f);
        Debug.Log(transform.rotation);
    }
}
