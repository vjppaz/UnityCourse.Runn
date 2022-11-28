using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10f;

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

    void PrintInstruction()
    {
        Debug.Log("Welcome to Runn");
        Debug.Log("Move your runner with ASDW or with arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        var xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        this.transform.Translate(xValue, 0, zValue);
    }
}
