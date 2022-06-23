using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scorePlayer1; 
    public Text scorePlayer2;
    public Text scorePlayer3; 
    public Text scorePlayer4;  
 
    public ScoreManager manager;

    private void Update() {
        scorePlayer1.text = manager.player1Score.ToString();
        scorePlayer2.text = manager.player2Score.ToString();
        scorePlayer3.text = manager.player3Score.ToString();
        scorePlayer4.text = manager.player4Score.ToString();
    }
}
