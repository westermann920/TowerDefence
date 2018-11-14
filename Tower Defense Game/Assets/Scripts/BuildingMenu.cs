﻿using UnityEngine;
using System.Collections;
using Valve.VR;

public class BuildingMenu: MonoBehaviour
{
    SteamVR_TrackedObject obj; // finding the controller
    [Header("Setup")]
    public GameObject buttonHolder; //empty object that contains the buttons
    public GameObject builderPointer;
    public GameObject TowerFoundation;
    public GameObject BuildingBall;
    public GameObject Hand;

    [Header("Debug")]
    public bool buttonEnabled; // saying whether or the empty object is enabled

    // Public booleans, need to be accesed in other scripts
    public bool holding;
    public bool holdingFoundation;
    public bool holdingBall;
   

    
    void Start()
    {
        obj = GetComponent<SteamVR_TrackedObject>();
        buttonHolder.SetActive(false);
        buttonEnabled = false;
        holdingFoundation = false;
        holdingBall = false;
        holding = false;
    } // Start end

    void Update()
    {

        MenuOpen();
        PlaceObject();
    } // Update end

    void MenuOpen () {

        var device = SteamVR_Controller.Input(4); //you are getting the device and setting it here
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu)) //When you press the button above the Dpad you will do this function
        {
            Debug.Log("Buttons should be enabled");
            if (buttonEnabled == false)
            {
                buttonHolder.SetActive(true);
                buttonEnabled = true;
            }
            else if (buttonEnabled == true)
            {
                buttonHolder.SetActive(false);
                buttonEnabled = false;
            }
        }
    }// MenuOpen end

    void PlaceObject() {

        var device = SteamVR_Controller.Input(3);

        if (holdingFoundation) {

            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                builderPointer.SetActive(true);
            }
            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger)) {

                Vector3 vec = new Vector3(Hand.transform.position.x, 0.01f, Hand.transform.position.z);
                Instantiate(TowerFoundation, vec, Quaternion.identity);

                builderPointer.SetActive(false);
                holdingFoundation = false;
                holding = false;
            }

        }
        if (holdingBall) {
            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)) {

                builderPointer.SetActive(true);
            }

            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger)) {

                Vector3 vec = new Vector3(Hand.transform.position.x, 0.01f, Hand.transform.position.z);
                Instantiate(BuildingBall, vec, Quaternion.identity);

                builderPointer.SetActive(false);
                holdingBall = false;
                holding = false;

            }
        }
    } // PlaceObjecft end
} // BuildingMenu end