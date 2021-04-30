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

    public static int score = 0;

    GameObject exploder;

    AudioSource splatSound;
    

    // Start is called before the first frame update
    void Start()
    {
        splatSound = splatSoundObject.GetComponent<AudioSource>();//getting audioSource object
    }

    // Update is called once per frame
    void Update()
    {
        //checking if left mouse click is clicked and if the game is paused or not
        anim.SetInteger("AttackingState", 2);
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            
             anim.SetInteger("AttackingState", attackNum);
             //checking wich animation to play
            if(attackNum == 0){
               
                attackNum = 1;
            }
            else
            {
              
                 attackNum = 0;
            }
           
            attacking = true;
            Invoke("attackingToFalse", 0.3f);//setting the attackingstate to false after .3 seconds
        }
       
    }
    void attackingToFalse(){
        attacking = false;
    }

    void killParticle(){//function that destroys particlesystem
        if(exploder != null)
            Destroy(exploder);
    }

    //checks for collisions with enemies
    private void OnTriggerEnter(Collider other) {
        SpawnEnemeies se = enemySpawner.GetComponent<SpawnEnemeies>();
        if (other.CompareTag("Enemy") && attacking) { 
            attack.score += 100;
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
