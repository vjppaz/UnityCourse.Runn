using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float speed = 150;

    // Update is called once per frame
    void Update()
    {
        var deltaSpeed = speed * Time.deltaTime;
        transform.Rotate(0f, deltaSpeed, 0f);
    }
}
