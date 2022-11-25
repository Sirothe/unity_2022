using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab06_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        // if (other.gameObject.CompareTag("Player")) {
        //     Vector3 test = new Vector3();
        //     if (test.y > 0) {
        //         test.y = 0;
        //     }
        //     test.y =  Mathf.Sqrt(1.0f * -3.0f * 10000f * -9.81f);
        //     other.gameObject.GetComponent<CharacterController>().Move(test * Time.deltaTime);
        // }
        // jump script not working at this moment
    }
}
