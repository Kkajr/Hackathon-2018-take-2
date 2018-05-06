using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Axisscript : MonoBehaviour
{
    public GameObject cube;
    public SteamVR_TrackedController _controller;
    public GameObject sphere;
    private float yPos;
    private float initialY = 0f, finalY = 0f;
    public bool condition = false;
    public Vector3 change;
    public Vector3 vBase;
    public bool trigger = false;
    public GameObject classroom;
    private int count = 0;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }
    
    public SteamVR_TrackedObject trackedObj;

    
    private void OnEnable()
    {
        Debug.Log(_controller);
        _controller.TriggerClicked += HandleTriggerClicked;
    }

    private void OnDisable()
    {
        _controller.TriggerClicked -= HandleTriggerClicked;
        condition = false;
    }

  


    void HandleTriggerClicked(object sender, ClickedEventArgs e)
    {
        condition = true;
        
    }


    void Update()
    {

        if (controller == null)
        {

            Debug.Log("Controller not initialized");

            return;

        }

        condition = controller.GetPress(triggerButton);
        if (!condition) {
            trigger = false;
            count = 0;
        }
        if (condition && trigger)
        {
            if (count % 2 == 0) {
                vBase = new Vector3(transform.parent.localScale.x, transform.parent.localScale.y, transform.parent.localScale.z);
                count = 1;
            }
            else {
                vBase = new Vector3(transform.parent.localScale.x, transform.parent.localScale.y, transform.parent.localScale.z);
                initialY = sphere.transform.position.y - 1.4f;
                change = new Vector3(0, (finalY - initialY), 0);
                Scale.scale(change, cube);
                Scale.scale(change, classroom);
                change = new Vector3(0, 0, (finalY - initialY));
                transform.parent.localScale = vBase - 3.334f *change;
                finalY = sphere.transform.position.y - 1.4f;
                
            }
        }

    }


    void OnTriggerEnter(Collider other)
    {
        trigger = true;
    }
    void OnTriggerExit(Collider other)
    {
        //trigger = false;
    }

    private void OnTriggerStay(Collider other)
    {
        trigger = true;
    }


}

