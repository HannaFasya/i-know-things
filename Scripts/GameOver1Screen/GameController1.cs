using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{
    public GameOver1Screen GameOver1Screen;
    int maxPlatform = 0;

    public void GameOver() 
    {
        GameOver1Screen.Setup(maxPlatform);
    }
}

    
