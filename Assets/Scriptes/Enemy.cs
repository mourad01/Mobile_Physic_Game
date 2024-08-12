using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(PlayerLauncher.Instance.player == null)
        {
            return;
        }
        if (collision.relativeVelocity.magnitude > 2 && PlayerLauncher.Instance.player.isLunched)
        {
            
            GameManager.instance.DestroyEnemy(this);

        }
        
    }
}
