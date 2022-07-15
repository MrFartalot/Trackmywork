using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(5, 7, 3);              //changes location
        transform.localScale = Vector3.one * 2f;                //changes size
        
        Material material = Renderer.material;                  //assigns other meterial
        
        material.color = new Color(0.8f, 0.7f, 6.0f, 2.4f);     //changes color
    }
    
    void Update()
    {
        transform.Rotate(2.0f * Time.deltaTime, 2.0f, 1.0f);   //rotates the cube
    }
}
