using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer
{
    Side,
    Straigh
}

public class PaddleController : MonoBehaviour
{
    public KeyCode leftUpKey;
    public KeyCode rightDownKey;
    public float speed;
    private Rigidbody rig;
    public ePlayer player;
    // Start is called before the first frame update
    void Start()
    {
        rig= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if(player == ePlayer.Straigh){
            if(Input.GetKey(leftUpKey))
            {
                return Vector3.left * speed;
            }
            if(Input.GetKey(rightDownKey))
            {
                return Vector3.right * speed;
            }
        } 
        if(player == ePlayer.Side){
            
            if(Input.GetKey(leftUpKey))
            {
                return Vector3.forward * speed;
            }
            if(Input.GetKey(rightDownKey))
            {
                return Vector3.back * speed;
            }
        }
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity=movement;
    }
}
