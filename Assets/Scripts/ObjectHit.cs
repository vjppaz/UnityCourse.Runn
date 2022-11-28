using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material CrushedWallMaterial;

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Player")
        {
            var meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = CrushedWallMaterial;
        }
    }
}
