using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DeathPlaneController : MonoBehaviour
{

    public Transform playerSpawnPoint;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Death");
        if(collision.gameObject.name == "Player")
        {
            Respawn(collision.gameObject);
        }
    }

    public void Respawn(GameObject go)
    {
        go.transform.position = playerSpawnPoint.position;
    }
}
