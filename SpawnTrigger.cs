using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public GameObject Enity;
    public GameObject SpawnPoint;



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Enity, SpawnPoint.transform.position, Quaternion.identity);
            Destroy(SpawnPoint);
        }
    }

}
