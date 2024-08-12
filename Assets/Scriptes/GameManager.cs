using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject > availablePlayer = new List<GameObject>(); 
    public List<Enemy> enemies = new List<Enemy>();

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
       if(availablePlayer.Count > 0 && enemies.Count>0){
            GameUi.instance.nextButton.SetActive(true);

        }
        else
        {
            GameUi.instance.LunchEndedScreen(enemies.Count==0);
        }
    }
    public void DestroyEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        Destroy(enemy.gameObject);
    }
}
