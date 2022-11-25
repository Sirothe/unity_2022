using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab06_01 : MonoBehaviour
{

    public GameObject block;
    private bool direction = false;
    public float speed = 1.0f;

    void Start() {
    }

    private void OnTriggerStay(Collider other) {
        if (block.transform.position.x > 14 && direction == false) {
            block.transform.position = block.transform.position + Vector3.left * speed * Time.deltaTime;
        }
        if (block.transform.position.x < 14) {
            block.transform.position = new Vector3(14,block.transform.position.y,block.transform.position.z);
            direction = true;
        }
        if (block.transform.position.x > 39) {
            block.transform.position = new Vector3(39,block.transform.position.y,block.transform.position.z);
            direction = false;
        }
        if (block.transform.position.x < 39 && direction == true) {
            block.transform.position = block.transform.position + Vector3.right * speed * Time.deltaTime;
        }
    }
}