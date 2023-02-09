using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 10.0f;

    public GameObject completeLevelUI;
    public GameObject credits;

    public void CompleteLevel()
    {
        //Debug.Log("LEVEL WON!!");
        completeLevelUI.SetActive(true);
        credits.SetActive(true);

    }

    public void EndGame ()
    {
        if(gameHasEnded == true)
        {
            credits.SetActive(true);
            Debug.Log("Game Over!");
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        credits.SetActive(false);
    }

}