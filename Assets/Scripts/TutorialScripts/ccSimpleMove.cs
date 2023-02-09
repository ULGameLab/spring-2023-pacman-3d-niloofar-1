using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccSimpleMove : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]
    private float playerSpeed = 3;
    [SerializeField]
    private float rotateSpeed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);        
        controller.SimpleMove(transform.forward * playerSpeed * Input.GetAxis("Vertical"));       
    }
}
