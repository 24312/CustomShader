using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Candy"))
        {
           
            Destroy(other.gameObject);
            renderer.material.SetVector("_Rotation", new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
           
        }
    }
}
