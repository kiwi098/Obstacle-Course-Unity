using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xval = 0.00f;
    //[SerializeField] float yval = 0.00f;
    //[SerializeField] float zval = 0.00f;

    [SerializeField] float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // Print in console
    void PrintInstruction()
    {
        Debug.Log("Yahallo!");
        Debug.Log("Bruh");
    }

    // Player Mover
    void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yVal = 0f;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xVal,yVal,zVal);
    }
}
