using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum gameState
{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    public gameState currentGameState = gameState.menu;

    public static GameManager sharedInstance;

    private void Awake()
    {
        if (sharedInstance == null)
            sharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        SetGameState(gameState.inGame);
    }

    public void GameOver()
    {
        SetGameState(gameState.gameOver);
    }

    public void GameMenu()
    {
        SetGameState(gameState.menu);
    }

    void SetGameState(gameState newGameState)
    {
        switch (newGameState)
        {
            case gameState.menu:
                
                break;
            case gameState.inGame:

                break;
            case gameState.gameOver:

                break;
        }
        currentGameState = newGameState;
    }
}
