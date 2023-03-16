using UnityEngine;
using System.Collections;

public class cath : MonoBehaviour
{
    public int score;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Good")
        {
            
            score = score + 10;
            
            Destroy(other.gameObject);
        }
        
        if (other.gameObject.tag == "Bad")
        {
            
            score = score - 10;
            Destroy(other.gameObject);
        }
    }
}