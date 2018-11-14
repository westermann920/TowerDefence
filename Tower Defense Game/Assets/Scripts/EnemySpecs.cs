﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpecs : MonoBehaviour {

    GameObject playerBase, Overlord;

    [Header("Minion Stats")]
    public int health = 5;
   
	// Use this for initialization
	void Start () {
        playerBase = GameObject.FindGameObjectWithTag("Base");
        Overlord = GameObject.FindGameObjectWithTag("Overlord");
    }// Start end

    // Update is called once per frame
    void Update()
    {
        var currentPosition = transform.position;
        if (playerBase.transform.position.x != currentPosition.x && playerBase.transform.position.x > currentPosition.x)
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        }
        else if (playerBase.transform.position.x != currentPosition.x && playerBase.transform.position.x < currentPosition.x)
        {
            transform.position += new Vector3(1 * Time.deltaTime * -1, 0, 0);
        }

        if (playerBase.transform.position.z != currentPosition.z && playerBase.transform.position.z > currentPosition.z)
        {
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime);
        }
        else if (playerBase.transform.position.z != currentPosition.z && playerBase.transform.position.z < currentPosition.z)
        {
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime * -1);
        }

    }// Update end

    public void Damaged(int damageValue)
    {
        health -= damageValue;
        if (health <= 0)
        {
            EnemyWaves enemy = Overlord.GetComponent<EnemyWaves>();
            enemy.MinionDead(1);    
            Destroy(gameObject);
           
        }
    }// Damaged end

}
