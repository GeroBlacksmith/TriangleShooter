using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
    private GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Running;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.Ended:
                Debug.Log("The Game has ended.");
                break;
            case GameState.Running:
                Debug.Log("The Game is running.");
                break;
            case GameState.Pause:
                Debug.Log("The Game is paused.");
                break;
        }
    }
}

public enum GameState { Running , Pause , Ended }