using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public GameObject ball;
    public int maxCountBall;
    public int spawnInterval;
    private float timer;
    [System.Serializable]
    public class SpawnPoint
    {
        public GameObject PointObject;
        public float X;
        public float ZMax;
        public float ZMin;
    }
    public List<SpawnPoint> SpawnPointList;

    public List<GameObject> ballList;
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<GameObject>();
        timer=0;
        GenerateBall();
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>spawnInterval )
        {
            GenerateBall();
            timer-=spawnInterval;
        }
    }
    
    public void GenerateBall()
    {
        if(ballList.Count >= maxCountBall)
        {
            return;
        }
        
        int randomIndexSpawn = Random.Range(0, SpawnPointList.Count);

        GameObject ballSpawn = Instantiate(
            ball,new Vector3(
                SpawnPointList[randomIndexSpawn].PointObject.transform.position.x,
                SpawnPointList[randomIndexSpawn].PointObject.transform.position.y,
                SpawnPointList[randomIndexSpawn].PointObject.transform.position.z),
            Quaternion.identity,
            spawnArea
        );

        ballSpawn.SetActive(true);
        ballSpawn.GetComponent<BallController>().speed=new Vector3(
            SpawnPointList[randomIndexSpawn].X,0,
            Random.Range(SpawnPointList[randomIndexSpawn].ZMax,SpawnPointList[randomIndexSpawn].ZMin)
        );

        ballSpawn.GetComponent<BallController>().LaunchBall();

        ballList.Add(ballSpawn);
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
}
