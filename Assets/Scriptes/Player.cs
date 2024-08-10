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
        rg.isKinematic = true;


    }
    private void Start()
    {
        
    }

    private void Update()
    {
        if(isLunched && rg.IsSleeping()) {
            //next Player
            Destroy(gameObject);
        }


    }

    public void Lunch(Vector2 vector)
    {
        rg.isKinematic = false;
        rg.AddForce(vector * 5 , ForceMode2D.Impulse);

    }
}
