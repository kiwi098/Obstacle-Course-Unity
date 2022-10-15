using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpCount = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            bumpCount = bumpCount + 1;
            Debug.Log("Bump Count: " + bumpCount);
        }
    }
}
