using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerscript : MonoBehaviour
{
    private Vector2 targetPos;
    public float yIncrement;
    public float speed;
    public float maxheight;
    public float minheight;
    public int health=3;
    public GameObject effect;
    public Text healthdisplay;
    public GameObject playersound;
    public Gamemanager game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        healthdisplay.text = health.ToString();
        if(health==0)
        {
            game.gameover();  
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<maxheight)
        {
            Instantiate(playersound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
         
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y>minheight)
        {
            Instantiate(playersound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
            
        }

    }
}
