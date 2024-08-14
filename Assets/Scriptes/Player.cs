using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rg;

    public bool isLunched;
    

    private void Awake()
    {
        
        rg.bodyType = RigidbodyType2D.Kinematic;


    }
    private void Start()
    {
        
    }

    private void Update()
    {
        if(isLunched && rg.IsSleeping()) {
         
            GameManager.instance.PlayerFinished();
            Destroy(gameObject);
        }


    }

    public void Lunch(Vector2 vector)
    {
        rg.bodyType = RigidbodyType2D.Dynamic;
        rg.AddForce(vector * 5 , ForceMode2D.Impulse);

    }
}
