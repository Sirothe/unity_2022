using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_06 : MonoBehaviour
{
    // Smooth towards the height of the target

    public Transform target;
    // float smoothTime = 0.3f;
    // float yVelocity = 0.0f;

    void Update()
    {
        // float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        // transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);

        float newPositionY = Mathf.Lerp(transform.position.y,target.position.y,0.003f);
        float newPositionZ = Mathf.Lerp(transform.position.z,target.position.z,0.003f);
        transform.position = new Vector3(transform.position.x,newPositionY,newPositionZ);
    }
}
