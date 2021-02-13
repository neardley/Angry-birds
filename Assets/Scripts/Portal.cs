using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Shot_behaviour person;
    // Start is called before the first frame update
    void Start()
    {
        person = FindObjectOfType<Shot_behaviour>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (ScoreTracker.WhatLvl() == 0)
            {
                ScoreTracker.Changelvl();
                SceneManager.LoadScene(1);
            }else if (ScoreTracker.WhatLvl() == 1)
            {
                ScoreTracker.Changelvl();
                Debug.Log("Portal Active");
                person.respawn();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
