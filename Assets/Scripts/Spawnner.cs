using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject[] obst;
    private float timebtwspawn;
    public float starttimebtwspawn;
    public float decreasetime;
    public float mintime=0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timebtwspawn<=0)
        {
            int rand = Random.Range(0, obst.Length);
            Instantiate(obst[rand], transform.position, Quaternion.identity);
            timebtwspawn = starttimebtwspawn;
            if(starttimebtwspawn>mintime)
            {
                starttimebtwspawn -= decreasetime;
            }
        }
        else
        {
            timebtwspawn -= Time.deltaTime;
        }
        
    }
}
