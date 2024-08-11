using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Player player;
    public float offset = 2.0f;

    public static CameraController instance;
     void Awake()
    {
        instance = this; 
    }
     void FixedUpdate()
    {
        if(player == null) {
            return; 
        }
        if(player.isLunched==true && player.transform.position.x >= transform.position.x - offset) {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x + offset,1,-10 ), Time.deltaTime * 10);
        }

    }

    public void SetPlayer(Player newPlayer)
    {
        player = newPlayer;
        Vector3 newPos = player.transform.position;
        newPos.z = -10;
        transform.position = newPos;
    }


}
