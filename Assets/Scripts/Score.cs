using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int hitCount = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Hit")
        {
            return;
        }
        hitCount ++;
        Debug.Log("You've bumped into a thing this many times:" + hitCount);
    }
}
