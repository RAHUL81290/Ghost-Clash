using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoremanager : MonoBehaviour
{
    public int score;
    public Text scoredisplay;
    public Text scoredisplay1;
    public Text highscore;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    private void Update()
    {
        scoredisplay.text = score.ToString();
        scoredisplay1.text = score.ToString();
    }
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
            {
            score++;
            Debug.Log(score);
        }
        if(score>PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscore.text = score.ToString();
        }
        
    }
}
