using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnitySpawnTrigger : MonoBehaviour
{
    public GameObject Enity;
    public Transform[] EnitySpawnerPositions;
    public int _randomSpawnPoints;
    public float RepeatRate = 3f;
    public int DestroySpawner = 20;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("EnitySpawner", 1f, RepeatRate);
            Destroy(gameObject, DestroySpawner);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }


    public void EnitySpawner()
    {
        _randomSpawnPoints = Random.Range(0, EnitySpawnerPositions.Length);
        Instantiate(Enity, EnitySpawnerPositions[_randomSpawnPoints].position, Quaternion.identity);
    }
}
