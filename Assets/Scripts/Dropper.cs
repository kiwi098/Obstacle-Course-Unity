using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBodyGravity;
    [SerializeField] float dropTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBodyGravity = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBodyGravity.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTime)
        {
            //Debug.Log("Drop");
            renderer.enabled = true;
            rigidBodyGravity.useGravity = true;
        }
    }
}
