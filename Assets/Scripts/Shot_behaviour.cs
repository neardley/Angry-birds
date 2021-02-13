using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shot_behaviour : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    private Rigidbody rb;
    private bool isShoot;
    private Vector3 spawnPos;
    private score_counter sC;
    private float fm; // force multiplier
    private LinkedList<BlockBehavior> blocks;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fm = 3;
        spawnPos = transform.position;
        blocks = new LinkedList<BlockBehavior>();
        foreach(BlockBehavior block in FindObjectsOfType<BlockBehavior>())
        {
            if(block.CompareTag("Block"))
            blocks.AddFirst(block.GetComponent<BlockBehavior>());
        }
        sC = FindObjectOfType<Text>().GetComponent<score_counter>();


    }
    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
        //mousePressDownPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
       // mouseReleasePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Shoot(mouseReleasePos - mousePressDownPos);
    }
    

    void Shoot(Vector3 Force)
    {
        Debug.Log("fire!");
        if (isShoot)
        {
            transform.position = spawnPos;
            foreach(BlockBehavior block in blocks)
            {
                block.reBuild();
            }
            isShoot = false;
            return;
        }
        else if (ScoreTracker.AmmoCheck())
        {
            sC.changeTxt();
            rb.AddForce(new Vector3(Force.x, Force.y, Force.z) * fm);
            isShoot = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void respawn()
    {
        transform.position = spawnPos;
        sC.changeTxt();
    }
}
