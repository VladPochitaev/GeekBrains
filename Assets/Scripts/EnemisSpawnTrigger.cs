using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemisSpawnTrigger : MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] EnemySpawnPoints;
    private int _randomSpawnPoints;
    public float RepearRate = 1f;
    public int DestroySpawner = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
        InvokeRepeating("EnemySpawner", 0.5f, RepearRate);
            Destroy(gameObject, DestroySpawner);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        
        }

       
    }
    private void EnemySpawner()
    {
        _randomSpawnPoints = Random.Range(0, EnemySpawnPoints.Length);
        Instantiate(Enemy, EnemySpawnPoints[_randomSpawnPoints].position, Quaternion.identity);
    }


}
