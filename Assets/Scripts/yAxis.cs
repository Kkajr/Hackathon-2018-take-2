using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class yAxis : MonoBehaviour
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
        if (!condition)
            trigger = false;
        if (condition && trigger)
        {
            vBase = new Vector3(transform.parent.localScale.x, transform.parent.localScale.y, transform.parent.localScale.z);

            initialY = sphere.transform.position.z - (-0.03f);
            change = new Vector3(0, 0, (finalY - initialY));
            Scale.scale(change, cube);
            Scale.scale(change, classroom);
            change = new Vector3(0, 0, (finalY - initialY));
            transform.parent.localScale = vBase - 3.334f * change;
            finalY = sphere.transform.position.z - (-0.03f);

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

