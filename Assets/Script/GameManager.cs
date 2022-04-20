using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject mainMenuPanel;
    public GameObject gameOverPanel;
    public GameObject bird;
    public GameObject ScoreLabel;

    public static bool isGameOver;
    public  Image image;
    public Text scoreTxt;
    static long count = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 0;
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        isGameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
            image.enabled = true;

    }


    public  void score()
    {
        count++;
        scoreTxt.text = "SCORE  " + count;
    }

    public void startGame()
    {
        Time.timeScale = 1;
        mainMenuPanel.SetActive(false);
        bird.SetActive(true);
        ScoreLabel.SetActive(true);
        







    }

    
}
