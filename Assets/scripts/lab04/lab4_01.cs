using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class lab4_01 : MonoBehaviour
{

    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int objectsToGenerate = 0;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;

    // Start is called before the first frame update
    void Start()
    {
        var platformInfo = GetComponent<Renderer>();
        var blockInfo = block.GetComponent<Renderer>();
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(Mathf.RoundToInt(platformInfo.bounds.center.x - platformInfo.bounds.extents.x), Mathf.RoundToInt(platformInfo.bounds.extents.x * 2)).OrderBy(x => Guid.NewGuid()).Take(objectsToGenerate));
        List<int> pozycje_z = new List<int>(Enumerable.Range(Mathf.RoundToInt(platformInfo.bounds.center.z - platformInfo.bounds.extents.z+1), Mathf.RoundToInt(platformInfo.bounds.extents.z * 2)).OrderBy(x => Guid.NewGuid()).Take(objectsToGenerate));
        Debug.Log(blockInfo.bounds);

        for(int i=0; i<objectsToGenerate; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerujObiekt()
    {
        foreach(Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
