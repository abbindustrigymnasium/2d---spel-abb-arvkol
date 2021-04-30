using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPointerMovement : MonoBehaviour
{
    Transform pointer;

    float speed = 32f;
    float horizontalDir;
    float  verticalDir;
    // Start is called before the first frame update
    void Start()
    {
            pointer = GetComponent<Transform>();
           
    }

    // Update is called once per frame
    void Update()
    {
        //updates pointer position for car object to follow
       horizontalDir = Input.GetAxis("Horizontal");
       verticalDir = Input.GetAxis("Vertical") ;
       Vector3 move = new Vector3(horizontalDir,0, verticalDir);
       pointer.position+= move*speed*Time.deltaTime;
    }
}
