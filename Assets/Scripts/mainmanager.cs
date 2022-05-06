using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanager : MonoBehaviour
{
   public void play()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void quit()
    {
        Application.Quit();
    }
}
