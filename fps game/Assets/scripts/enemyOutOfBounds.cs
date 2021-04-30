using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyOutOfBounds : MonoBehaviour
{
    public GameObject enemySpawner;

    //if the enemies intersect out of bounds box then they get destroyed
    private void OnTriggerEnter(Collider other) {
        SpawnEnemeies se = enemySpawner.GetComponent<SpawnEnemeies>();
        if (other.CompareTag("Enemy")) { 
            Destroy(other.transform.root.gameObject);   
            se.enemyCount --; 
        }     
    }
}
