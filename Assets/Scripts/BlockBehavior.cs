using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    private Vector3 spawnPos;
    private Quaternion spawnRot;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
        spawnRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reBuild()
    {
        /* Makes Game much harder
        transform.rotation = spawnRot;
        transform.position = spawnPos;
        */
    }
}
