using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void gameover()
    {
        canvas.SetActive(true);
        Time.timeScale = 0;
    }
     public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void gotomenu()
    {
        SceneManager.LoadScene(0);
    }
   

}
