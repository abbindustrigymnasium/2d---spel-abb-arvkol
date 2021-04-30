using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStartMenuNinjas : MonoBehaviour
{

    public static int ninjas = 0;
    public GameObject ninja;

    Vector3 scale;

    // Start is called before the first frame update
    void Start()
    {
         ninjas = 0;
         scale = new Vector3(4.1f, 4.1f, 4.1f);
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Random.Range(420, 580);
        float zPos = Random.Range(-530, -600);
        if(ninjas < 3){
            GameObject newNinja = Instantiate(ninja, new Vector3(xPos, 137.4f, zPos), Quaternion.identity);
            newNinja.transform.localScale = scale;
            ninjas ++;
        }
    }
}
