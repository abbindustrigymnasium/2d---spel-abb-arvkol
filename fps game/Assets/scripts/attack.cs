using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class attack : MonoBehaviour
{
    public Animator anim;
    
    public Transform particleSys;

    public GameObject enemySpawner;

    public GameObject splatSoundObject;

    bool attacking = false;

    int attackNum = 0;

    GameObject exploder;

    AudioSource splatSound;
    

    // Start is called before the first frame update
    void Start()
    {
        splatSound = splatSoundObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("AttackingState", 2);
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            
             anim.SetInteger("AttackingState", attackNum);
            if(attackNum == 0){
               
                attackNum = 1;
            }
            else
            {
              
                 attackNum = 0;
            }
           
            attacking = true;
            Invoke("attackingToFalse", 0.3f);
        }
       
    }
    void attackingToFalse(){
        attacking = false;
    }

    void killParticle(){
        if(exploder != null)
            Destroy(exploder);
    }

    private void OnTriggerEnter(Collider other) {
        SpawnEnemeies se = enemySpawner.GetComponent<SpawnEnemeies>();
        if (other.CompareTag("Enemy") && attacking) { 
            killParticle();
            exploder = ((Transform)Instantiate(particleSys, other.transform.position, other.transform.rotation)).gameObject;
            Destroy(other.transform.root.gameObject);   
            //attacking = false;  
            se.enemyCount --; 
            splatSound.Play(0); 
        }     
        Invoke("killParticle",0.2f);  
    }
}
