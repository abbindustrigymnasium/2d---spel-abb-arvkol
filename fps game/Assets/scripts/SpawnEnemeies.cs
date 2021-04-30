using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class SpawnEnemeies : MonoBehaviour
{

    public GameObject enemy;
    public TextMeshProUGUI t;

    float xPos;
    float zPos;

    public static int waveNum = 0;

    public int enemyCount = 1;

    bool started = false;

    int targetCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        //spawns a initial enemy so that the player can kill the ammount of enemies necesary to progress since a enemy is used a refrence for other enemies to spawn(check the scene to understand)
        xPos = Random.Range(-4, 11);
        zPos = Random.Range(10, 24);
        Instantiate(enemy, new Vector3(xPos, 12, zPos), Quaternion.identity);
        //StartCoroutine(spawn());
        spawn();
    }
    void Update(){
        //Debug.Log(enemyCount);
        //checks if a new wave of enemies should spawn
        if(enemyCount <= 0){
            enemyCount = 0;
            //StartCoroutine(spawn());
            spawn();
            waveNum++;
            targetCount ++;
            
        }
        t.text =attack.score.ToString();
    }

    /*IEnumerator*/ void spawn(){//initiates wave of enemies
        for(int e = enemyCount; e < targetCount; e++)
        {
            EnemyMovement em = enemy.GetComponent<EnemyMovement>();
            if(em != null){
                em.speed = 5f+0.3f*waveNum;
                if(em.speed > 9)
                    em.speed = 9;
            }
            xPos = Random.Range(-4, 11);
            zPos = Random.Range(10, 24);
            Instantiate(enemy, new Vector3(xPos, 12, zPos), Quaternion.identity);
            //yield return new WaitForSeconds(0.1f);
            enemyCount ++;
        }
    }
}
