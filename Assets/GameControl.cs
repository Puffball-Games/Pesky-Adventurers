using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  This class is responsible for:
*   Winning or Losing
*   Level switching
*   Updating the UI
*   Keep track of game state
*/
public class GameControl : MonoBehaviour {
    public static GameControl instance;

    public GameState gameState = GameState.RESUMED;
    public int gameLevel = 1;

    //Initializer: makes this class a singleton
    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }
    }

    // Start is called before the first frame updat
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void pauseGame() {
        gameState = GameState.PAUSED;
    }

    public void endGame() {
        gameState = GameState.GAME_OVER;
    }

    public bool gameEnded() {
        return gameState == GameState.GAME_OVER;
    }
}

public enum GameState { 
    RESUMED,
    PAUSED,
    GAME_OVER
}
