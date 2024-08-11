using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    [SerializeField]
    private float backgroundParallaxRate = -3.0f;
    private Camera cam;
    
    void Start()
    {
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(cam.transform.position.x / backgroundParallaxRate , -2,0); 
    }
}
