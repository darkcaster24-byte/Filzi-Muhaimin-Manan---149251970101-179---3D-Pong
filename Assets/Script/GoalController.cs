using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eWall
{
    downWall,
    rightWall,
    upWall,
    leftWall
}

public class GoalController : MonoBehaviour
{
    public eWall wall;
    public Collider ball;
    public ScoreManager manager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision) {
        if(collision.tag=="ball")
        {
            
            if(wall==eWall.downWall)
            {
                manager.addPlayer1Score(1);
                Debug.Log("Goal Kambing 1");
            }
            if(wall==eWall.rightWall)
            {
                manager.addPlayer2Score(1);
                Debug.Log("Goal Kambing 2");
            }
            if(wall==eWall.upWall)
            {
                manager.addPlayer3Score(1);
                Debug.Log("Goal Kambing 3");
            }
            if(wall==eWall.leftWall)
            {
                manager.addPlayer4Score(1);
                Debug.Log("Goal Kambing 4");
            }
        }
    }
}
