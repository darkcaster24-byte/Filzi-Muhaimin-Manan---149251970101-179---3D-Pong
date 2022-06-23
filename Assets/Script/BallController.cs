using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    Rigidbody rig;
    public BallManager manager;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag=="Wall")
        {
            manager.RemoveBall(gameObject);
        }
    }

    public void LaunchBall()
    {
        rig = GetComponent<Rigidbody>();
        rig.AddForce(speed,ForceMode.Impulse);
    }
}
