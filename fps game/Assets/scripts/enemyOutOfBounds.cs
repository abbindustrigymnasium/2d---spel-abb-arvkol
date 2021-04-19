using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyOutOfBounds : MonoBehaviour
{
    public GameObject enemySpawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other) {
        SpawnEnemeies se = enemySpawner.GetComponent<SpawnEnemeies>();
        if (other.CompareTag("Enemy")) { 
            Destroy(other.transform.root.gameObject);   
            se.enemyCount --; 
        }     
    }
}
