using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float viive = 1f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground"){
            Debug.Log("Ouch! Hit my head! No helmet! How stupid of me!");
            
            Invoke("ReloadScene", viive);
    
        }
    }

    private void ReloadScene() {
        SceneManager.LoadScene(0);
    }

}
