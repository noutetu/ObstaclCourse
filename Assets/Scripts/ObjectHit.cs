using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        //一度色が変化している、もしくはプレイヤー以外のものに触れた場合はreturn
        if(gameObject.tag == "Hit" || other.gameObject.tag !="Player")
        {
            return;
        }

        GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";
    }
}
