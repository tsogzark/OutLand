using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlane : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chunkPlanePrefab;

    void Start()
    {
        Instantiate(chunkPlanePrefab, new Vector3(0,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
