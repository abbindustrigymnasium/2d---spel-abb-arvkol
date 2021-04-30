using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    
    public GameObject enemySpawner;

    public Transform enemy;

    public float speed = 3f;

    SpawnEnemeies se;

    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
       se = enemySpawner.GetComponent<SpawnEnemeies>();
    }

    // Update is called once per frame
    void Update()
    {
        //makes the enemies face and walk towards the player
        direction = player.position -enemy.position;

        Vector3 lookPos = player.position - enemy.position;
        lookPos.y = 0;
        lookPos = Quaternion.AngleAxis(5, Vector3.up) * lookPos;//fix the orientetation
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        enemy.rotation = Quaternion.Slerp(enemy.rotation, rotation, Time.deltaTime * 1f);

        direction = Vector3.Normalize(direction);

        enemy.position += direction*speed*Time.deltaTime;

        if(enemy.position.y < -130){
             Destroy(enemy.root.gameObject);   
            
            se.enemyCount--;
        }
        
    }
}
