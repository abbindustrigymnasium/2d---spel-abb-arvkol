using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDie : MonoBehaviour
{
    // public GameObject s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) { 
            // Restart r = s.GetComponent<Restart>();
            Restart.chosenLevel = SceneManager.GetActiveScene().buildIndex;
            Debug.Log("ur dead");
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2/*SceneManager.GetActiveScene().buildIndex+1*/);
        }
      
    }
}
