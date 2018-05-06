using UnityEngine;
using System.Collections;


public class VrControl : MonoBehaviour
{

    private SteamVR_TrackedController _controller;

    public bool press = false;
    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();
        _controller.TriggerClicked += HandleTriggerClicked;
    }
    private void OnDisable()
    {
        _controller.TriggerClicked -= HandleTriggerClicked;
        press = false;
    }
    private void HandleTriggerClicked(object sender, ClickedEventArgs e)
    {
        press = true;
    }




    private void OnTriggerStay(Collider other)
    {
        /*
    /*

        void OnTriggerEnter(Collider other)
        {
            
            Debug.Log("Trigger enter");
        }

        private void OnTriggerExit(Collider other)
        {
            
            Debug.Log("Trigger exit");
        }*/
    }
}
