﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPointList : MonoBehaviour {
    public GameObject pathPoint0;
    public GameObject pathPoint1;
    public GameObject pathPoint2;
    public GameObject pathPoint3;
    public GameObject pathPoint4;
    public GameObject pathPoint5;
    public GameObject pathPoint6;
    public GameObject pathPoint7;
    public GameObject pathPoint8;
    public GameObject pathPoint9;

    public List<GameObject> path = new List<GameObject>();
    
    public List<GameObject> getPathList()
    {
        return path;
    }

    void listAdder(GameObject point)
    {
        if (point != null)
        {
            path.Add(point);
            Debug.Log(point.name);
        }
    }

    // Use this for initialization
    void Start () {
        listAdder(pathPoint0);
        listAdder(pathPoint1);
        listAdder(pathPoint2);
        listAdder(pathPoint3);
        listAdder(pathPoint4);
        listAdder(pathPoint5);
        listAdder(pathPoint6);
        listAdder(pathPoint7);
        listAdder(pathPoint8);
        listAdder(pathPoint9);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}