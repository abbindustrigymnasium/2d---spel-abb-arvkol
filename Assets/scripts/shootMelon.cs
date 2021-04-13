using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class shootMelon : MonoBehaviour
{

    public GameObject enemy;
    public TextMeshProUGUI t;
    public Animator anim;
    public Transform particleSys;
    public Transform canon;
    GameObject exploder;
    public GameObject explosionSoundObject;
    AudioSource explosionSound;

    public float xPos;
    public float zPos;

    int waveNum = 0;

    public int enemyCount = 1;

    bool started = false;

    int targetCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        // xPos = Random.Range(-4, 11);
        // zPos = Random.Range(10, 24);
        // Instantiate(enemy, new Vector3(xPos, 12, zPos), Quaternion.identity);
        //StartCoroutine(spawn());
        explosionSound = explosionSoundObject.GetComponent<AudioSource>();
        spawn();
    }
    void Update(){
        //Debug.Log(enemyCount);
        if(enemyCount == 0){
            //StartCoroutine(spawn());
            spawn();
            waveNum++;
            
        }
        t.text = waveNum.ToString();
    }

    /*IEnumerator*/ void spawn(){
    
        melonMovement em = enemy.GetComponent<melonMovement>();
        if(em != null)
            em.speed = 5f+0.5f*waveNum;
        
        // xPos = Random.Range(-4, 11);
        // zPos = Random.Range(10, 24);
        anim.SetTrigger("shoot");
        StartCoroutine(initMelon());
        //yield return new WaitForSeconds(0.1f);
        enemyCount = 1;
    }

    IEnumerator initMelon(){
        killParticle(); 
        yield return new WaitForSeconds(1.2f);
        Vector3 adjustedCanon = canon.position+new Vector3(5,-1,10);
        exploder = ((Transform)Instantiate(particleSys, adjustedCanon, canon.rotation)).gameObject;
        Instantiate(enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
        explosionSound.Play(0);
        Invoke("killParticle", 0.5f); 
    }

    void killParticle(){
        if(exploder != null)
            Destroy(exploder);
    }
}
