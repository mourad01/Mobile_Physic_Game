using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject > availablePlayer = new List<GameObject>(); 
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        SpawnerNewPlayer();
    }
    public void SpawnerNewPlayer()
    {
        PlayerLauncher.Instance.SetNewPlayer(availablePlayer[0]);
        availablePlayer.RemoveAt(0);
    }

    public void PlayerFinished()
    {
        SpawnerNewPlayer();
    }
}
