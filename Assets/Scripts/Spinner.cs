using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    void RotateObject()
    {
        float xVal = 0f;
        float yVal = 1  * spinSpeed;
        float zVal = 0f;

        transform.Rotate(xVal,yVal,zVal);
    }
}
