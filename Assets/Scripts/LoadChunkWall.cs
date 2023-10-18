using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadChunkWall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;

    void Start()
    {
        Instantiate(block, new Vector3(0, 2, -50), Quaternion.identity);
        Instantiate(block, new Vector3(0, 2, 50), Quaternion.identity);
        Instantiate(block, new Vector3(50, 2, 0), Quaternion.Euler(0, 90, 0));
        Instantiate(block, new Vector3(-50, 2, 0), Quaternion.Euler(0, 90, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
