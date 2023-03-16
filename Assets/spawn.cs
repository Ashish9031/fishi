using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn: MonoBehaviour
{
    
    public GameObject rs;
    public GameObject[] items;
    public float startDelay,rate;

  
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, rate);
    }

    
    void Spawn()
    {
        
        Vector3 pos = new Vector3(Random.Range(gameObject.transform.position.x, rs.transform.position.x), gameObject.transform.position.y, 0);
        Instantiate(items[Random.Range(0, items.Length)], pos, gameObject.transform.rotation);
    }
}
