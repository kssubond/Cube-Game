using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject score;

    private bool gameHasEnded = false;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        score.SetActive(false);
    }

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
