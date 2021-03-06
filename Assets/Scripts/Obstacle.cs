using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); 
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            
            Instantiate(explosion, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<playerscript>().health -= damage;
            Debug.Log(other.GetComponent<playerscript>().health);
            Destroy(gameObject);
        }
    }
}
