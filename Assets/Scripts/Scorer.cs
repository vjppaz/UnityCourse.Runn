using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter;

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag != "Hit")
        {
            other.transform.tag = "Hit";
            counter++;
            Debug.Log($"You've bumped into a thing this many times: {counter}");
        }
    }
}
