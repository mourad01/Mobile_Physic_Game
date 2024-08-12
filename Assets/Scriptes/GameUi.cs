using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUi : MonoBehaviour
{
    public GameObject nextButton;
    public GameObject endSceen;
    public GameObject win;
    public GameObject lose;

    public static GameUi instance;

    private void Awake()
    {
        instance = this;
    }
    public void OnNextButtonClick()
    {
        GameManager.instance.SpawnerNewPlayer();
        nextButton.SetActive(false);
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LunchEndedScreen(bool isWin)
    {
        endSceen.SetActive(true);

        win.SetActive(isWin);
        lose.SetActive(!isWin);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
