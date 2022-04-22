using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] private float turnSpeed = 10f;

    
    void Start()
    {
        
    }

   
    void Update()
    {
        var horizontalRotation = Input.GetAxis("Horizontal");
        var changeSpeed = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * changeSpeed);
        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * horizontalRotation);
    }
}
