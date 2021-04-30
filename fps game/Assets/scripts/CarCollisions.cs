using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisions : MonoBehaviour
{
    public GameObject ninjaSpawnRef;
    GameObject exploder;
    public Transform particleSys;

    void killParticle(){
        if(exploder != null)
            Destroy(exploder);
    }
     //checks for collision
     private void OnTriggerEnter(Collider other) {
        killParticle();
        exploder = ((Transform)Instantiate(particleSys, other.transform.position, other.transform.rotation)).gameObject;
        Destroy(other.transform.root.gameObject);
        Invoke("killParticle",0.2f);  
        spawnStartMenuNinjas.ninjas --;
    }
}
