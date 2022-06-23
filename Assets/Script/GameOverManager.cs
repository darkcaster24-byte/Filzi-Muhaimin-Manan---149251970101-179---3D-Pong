using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text WinnerPlayer;
    // Start is called before the first frame update

    public void ShowGameOver(string player)
    {
        gameObject.SetActive(true);
        WinnerPlayer.text= player;
        if(player=="Player 1"){WinnerPlayer.color=Color.red;}
        if(player=="Player 2"){WinnerPlayer.color=Color.blue;}
        if(player=="Player 3"){WinnerPlayer.color=Color.cyan;}
        if(player=="Player 4"){WinnerPlayer.color=Color.yellow;}
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
