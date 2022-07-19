using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anda : MonoBehaviour
{
    public float gravity = 15.0f;
    public float vel;
    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
    }

    void movimento()
    {
        if(characterController.isGrounded){
            moveDirection = new Vector3(Input.GetAxis("MoveDireitaEsquerda"), 0.0f, Input.GetAxis("MoveCimaBaixo"));
            moveDirection *= vel;
            // if (Input.GetButton("Jump")) moveDirection.y = jumpspeed;
            moveDirection = transform.TransformDirection(moveDirection);
    
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
    

}
