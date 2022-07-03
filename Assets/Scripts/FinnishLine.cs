using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinnishLine : MonoBehaviour
{
    [SerializeField] float viive = 1f;
    [SerializeField] ParticleSystem  finnishEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player") {
            Debug.Log("Maaliviiva ylitetty!");
            Invoke("ReloadScene", viive);
        }
    }
    private void ReloadScene() {
        SceneManager.LoadScene(0);
    }

}
