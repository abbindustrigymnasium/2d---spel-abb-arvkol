using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class attackMelon : MonoBehaviour
{
    public Animator anim;
    
    public Transform particleSys;

    public GameObject splatSoundObject;

    public GameObject melonSpawn;

    bool attacking = false;

    int attackNum = 0;

    GameObject melonParticle;

    AudioSource splatSound;
    

    // Start is called before the first frame update
    void Start()
    {
        splatSound = splatSoundObject.GetComponent<AudioSource>();//getting audioSource
    }

    // Update is called once per frame
    void Update()
    {
        //checking if the player presses mousebutton and decides what attack animation to play
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
        if(melonParticle != null)
            Destroy(melonParticle);
    }

    //checks for collision
    private void OnTriggerEnter(Collider other) {
        shootMelon sm = melonSpawn.GetComponent<shootMelon>();
        if (other.CompareTag("Enemy") && attacking) { 
            killParticle();
            melonParticle = ((Transform)Instantiate(particleSys, other.transform.position, other.transform.rotation)).gameObject;
            Destroy(other.transform.root.gameObject);   
            sm.enemyCount --; 
            attacking = false;   
            splatSound.Play(0); 
        }     
        Invoke("killParticle",0.5f);  
    }
}