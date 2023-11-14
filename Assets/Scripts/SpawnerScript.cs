using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int sec = 0;
    void Update()
    {
        if (Time.realtimeSinceStartup > sec)
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            sec = sec + 3;
        }
    }
}