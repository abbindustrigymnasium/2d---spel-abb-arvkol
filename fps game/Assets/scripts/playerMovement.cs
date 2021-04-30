using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Rigidbody playerBody;
    public Transform groundCheck;
    public LayerMask groundMask;
    bool onGround;

    Vector3 velocity;
    float speed = 13f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
       //if the player touches the ground then he can jump
        onGround = Physics.CheckSphere(groundCheck.position, 0.1f, groundMask);
       /* if(Physics.OverlapSphere(groundCheck.position, 0.1f).Length < 2){
           onGround = false;
        }else{onGround = true;}*/

        velocity.y += -10*Time.deltaTime;

        if(onGround && Input.GetKey(KeyCode.Space)){//makes player jump
           velocity.y = Mathf.Sqrt(3*-2*-10);
        }
        if(onGround && velocity.y < 0){
            velocity.y = -2;     
        }
       
        
        
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move*speed*Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);

    }

}
