using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab06_03 : MonoBehaviour
{
    public GameObject block;
    public float speed = 1.0f;
    public List<Vector3> targets = new List<Vector3>() {new Vector3(19,2,11),new Vector3(21,2,15)};
    public int current = 0;
    float targetRadius = 0.1f;
    bool isFirstPosAdded = false;
    bool direction = false;

    private void OnTriggerStay(Collider other) {
        if (!isFirstPosAdded) {
            targets.Insert(0,block.transform.position);
            isFirstPosAdded = true;
        }
        if (Vector3.Distance(targets[current],block.transform.position) < targetRadius)
        {
            if (!direction) {
                current++;
                if (current>= targets.Count) {
                    current = current-1;
                    direction = true;
                }
            } else {
                current--;
                if (current == 0) {
                    direction=false;
                }
            }
        }
        block.transform.position = Vector3.MoveTowards(block.transform.position,targets[current],speed * Time.deltaTime);
        
    }
}
