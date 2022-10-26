using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_02 : MonoBehaviour
{

    public float speed = 0f;
    private float unitsMoved = 0f;
    // true - forward
    // false - backwards
    private bool direction = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        unitsMoved += speed * Time.deltaTime;
        if (unitsMoved < 10) {
            if (direction == true) {
                transform.Translate(speed * Time.deltaTime,0f,0f,Space.Self);
            } else {
                transform.Translate(-(speed * Time.deltaTime),0f,0f,Space.Self);
            }
        } else if (unitsMoved >= 10) {
            direction = !direction;
            unitsMoved = 0;
        }
        Debug.Log(unitsMoved);
    }
}
