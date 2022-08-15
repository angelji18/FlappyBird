using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject gameOverCanvas;

    public void Start()
    {
        gameOverCanvas.SetActive(false);
        new WaitForSeconds(2);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void Restart()
    {
        
        SceneManager.LoadScene(0);
        new WaitForSeconds(2);
    }
}
