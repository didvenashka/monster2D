using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitHelper : MonoBehaviour
{
   
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown()");
        GetComponent<Animator>().SetTrigger("Hit");
        GetComponent<Healthhelper>().GetHit(10);
    }
}

