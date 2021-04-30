using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melonMovement : MonoBehaviour
{
    
    public Transform enemy;

    public float speed = 5f;
    Vector3 direction;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //makes the melon move forwards and rotates it if the game is unpaused
        angle ++;

        direction = new Vector3(0,0,1);

        enemy.position += direction*speed*Time.deltaTime;
        
        if(Time.timeScale > 0)
            enemy.rotation = Quaternion.Euler(angle,0,0);
        
    }
}
