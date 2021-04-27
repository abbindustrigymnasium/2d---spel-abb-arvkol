using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisions : MonoBehaviour
{
    public GameObject ninjaSpawnRef;
    GameObject exploder;
    public Transform particleSys;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void killParticle(){
        if(exploder != null)
            Destroy(exploder);
    }
     private void OnTriggerEnter(Collider other) {
        killParticle();
        exploder = ((Transform)Instantiate(particleSys, other.transform.position, other.transform.rotation)).gameObject;
        Destroy(other.transform.root.gameObject);
        Invoke("killParticle",0.2f);  
        spawnStartMenuNinjas.ninjas --;
    }
}
