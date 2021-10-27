using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum GameState
{
    Start,
    Playing,
    Paused,
    Gameover,
    //-------
    COUNT
}
public enum Difficulty { Easy, Medium, Hard}

public class GameManager : Singleton<GameManager>

{
    public GameState gameState;
    public Difficulty difficulty;
    public float scoreMultiplyer;
    public float Score;
    // Start is called before the first frame update

    
    void Start()
    {
        gameState = GameState.Start;
        difficulty = Difficulty.Easy;
        SetUp();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            difficulty = Difficulty.Hard;
            Debug.Log(difficulty);
        }
    }
     public void SetUp()
    {
        switch(difficulty)
        {
            case Difficulty.Easy:
                scoreMultiplyer = 1;
                break;
            case Difficulty.Medium:
                scoreMultiplyer = 2;
                break;
            case Difficulty.Hard:
                scoreMultiplyer = 3;
                
                break;
            default:
                scoreMultiplyer = 1;
                break;
        }
    }
    public void AddScore(float amount)
    {
        Score += amount * scoreMultiplyer;
    }
}
