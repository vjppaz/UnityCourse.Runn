using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float DropTime;

    private Rigidbody rigidBody;
    private MeshRenderer meshRenderer;
    bool dropped = false;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        rigidBody.useGravity = false;
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >=DropTime && !dropped)
        {
            dropped = true;
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
