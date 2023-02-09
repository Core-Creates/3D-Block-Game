using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMove movement;
    public GameObject restartText;

    void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.tag == "Obstacle");
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //movementis set to enabled = false;
            GetComponent<PlayerMove>().enabled = false; // disable player movement on collison
            FindObjectOfType<GameManager>().EndGame();
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);      

        }

        
        
    }
    
}
