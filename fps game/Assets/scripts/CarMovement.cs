using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform pointer;

    Transform car;

    float speed = 32f;

    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        car =  GetComponent<Transform>();
    }

    // Update is called once per frame


    void Update()
    {
       
        direction = pointer.position - car.position;//get the direction to head towards

        Vector3 lookPos = pointer.position - car.position;;
        lookPos.y = 0;
        lookPos = Quaternion.AngleAxis(-90, Vector3.up) * lookPos;//fix the orientetation
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        
        car.rotation = Quaternion.Slerp(car.rotation, rotation, Time.deltaTime * 10f);//"smooth in" rotation
        
        direction = Vector3.Normalize(direction);

        if( (pointer.position - car.position).magnitude > 1)
            car.position += direction*speed*Time.deltaTime;//add vector to the position

    }
}
