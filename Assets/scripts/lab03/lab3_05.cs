using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_05 : MonoBehaviour
{

    public GameObject myPrefab;
    private List<(int,int)> usedPositions = new List<(int,int)>();
    private (int x,int z) generatedPos = (0,0);

    // Start is called before the first frame update
    void Start()
    {
        for(int x=0;x<10;x++) {
            (int x,int z) number = generateNumber(-4,5);
            Instantiate(myPrefab,new Vector3(number.x,0,number.z),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    (int,int) generateNumber(int min,int max)
    {
        generatedPos = (Random.Range(min,max),Random.Range(min,max));
        while (usedPositions.Contains(generatedPos))
        {
            generatedPos = (Random.Range(min,max),Random.Range(min,max));
        }
        usedPositions.Add(generatedPos);
        return generatedPos;
    }
}
