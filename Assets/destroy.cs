using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeliving;
    void Start()
    {

        Destroy(gameObject, timeliving);
    }
}