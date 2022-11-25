using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab06_02 : MonoBehaviour
{

    public GameObject block;
    private bool opening = true;
    public float speed = 1.0f;

    private void OnTriggerStay(Collider other) {
        if (block.transform.position.x > 11.75 && opening == true) {
            block.transform.position = block.transform.position + Vector3.left * speed * Time.deltaTime;
        }
        if (block.transform.position.x < 11.75f) {
            block.transform.position = new Vector3(11.75f,block.transform.position.y,block.transform.position.z);
        }
    }
    private void OnTriggerExit(Collider other) {
        opening = false;
    }
    private void FixedUpdate() {
        if (opening == false && block.transform.position.x < 13.25f) {
            block.transform.position = block.transform.position + Vector3.right * speed * Time.deltaTime;
        }
        if (opening == false && block.transform.position.x >= 13.25f) {
            block.transform.position = new Vector3(13.25f,block.transform.position.y,block.transform.position.z);
            opening = true;
        }
    }
}
