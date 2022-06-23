using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public int player3Score;
    public int player4Score;
    public int maxScore;
    public Collider Wall1;
    public Collider Wall2;
    public Collider Wall3;
    public Collider Wall4;
    public int player= 4;
    private bool player1=true;
    private bool player2=true;
    private bool player3=true;
    private bool player4=true;

    [System.Serializable]
    public class PlayerScore
    {
        public int score;
        public Collider Wall;
        public bool player;
    }
    public List<PlayerScore> PlayerScoreList;
    public GameOverManager manager;

    private void update()
    {
        
    }

    public void addPlayer1Score(int increment)
    {
        player1Score+=increment;
        if(player1Score>=maxScore)
        {
            Wall1.isTrigger=false;
            player-=1;
            player1=false;
            GameOver();
        }
    }

    public void addPlayer2Score(int increment)
    {
        player2Score+=increment;
        if(player2Score>=maxScore)
        {
            Wall2.isTrigger=false;
            player-=1;
            player2=false;
            GameOver();
        }
    }

    public void addPlayer3Score(int increment)
    {
        player3Score+=increment;
        if(player3Score>=maxScore)
        {
            Wall3.isTrigger=false;
            player-=1;
            player3=false;
            GameOver();
        }
    }

    public void addPlayer4Score(int increment)
    {
        player4Score+=increment;
        if(player4Score>=maxScore)
        {
            Wall4.isTrigger=false;
            player-=1;
            player4=false;
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("Dah Game Over Anjeng");
        if(player==1)
        {
            if(player1){manager.ShowGameOver("Player 1");}
            if(player2){manager.ShowGameOver("Player 2");}
            if(player3){manager.ShowGameOver("Player 3");}
            if(player4){manager.ShowGameOver("Player 4");}
        }
    }
    
}
