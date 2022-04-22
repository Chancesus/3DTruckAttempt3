using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for Following Truck with Camera

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Camera firstPerson;
    [SerializeField] private Camera thirdPerson;
    
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool firstPersonActive = false;
    private bool thirdPersonActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetKey(KeyCode.V))
        {
            if (firstPersonActive == false)
            {
                thirdPerson.enabled = false;
                firstPerson.enabled = true;
                firstPersonActive = true;
                thirdPersonActive = false;
            }
            else if (thirdPersonActive == false)
            {
                thirdPerson.enabled = true;
                firstPerson.enabled = false;
                thirdPersonActive = true;
                firstPersonActive = false;
            }
            
            
        }
    }
}
