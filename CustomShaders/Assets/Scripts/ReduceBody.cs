﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceBody : MonoBehaviour
{
    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
         renderer.material.SetVector("_Rotation", new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
    }
}
