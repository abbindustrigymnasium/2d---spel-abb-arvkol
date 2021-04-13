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

    int waveNum = 0;

    public int enemyCount = 1;

    bool started = false;

    int targetCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        xPos = Random.Range(-4, 11);
        zPos = Random.Range(10, 24);
        Instantiate(enemy, new Vector3(xPos, 12, zPos), Quaternion.identity);
        //StartCoroutine(spawn());
        spawn();
    }
    void Update(){
        //Debug.Log(enemyCount);
        if(enemyCount == 0){
            //StartCoroutine(spawn());
            spawn();
            waveNum++;
            targetCount ++;
            
        }
        t.text = waveNum.ToString();
    }

    /*IEnumerator*/ void spawn(){
        while (enemyCount < targetCount)
        {
            EnemyMovement em = enemy.GetComponent<EnemyMovement>();
            if(em != null)
                em.speed = 3f+0.1f*waveNum;
            xPos = Random.Range(-4, 11);
            zPos = Random.Range(10, 24);
            Instantiate(enemy, new Vector3(xPos, 12, zPos), Quaternion.identity);
            //yield return new WaitForSeconds(0.1f);
            enemyCount ++;
        }
    }
}
