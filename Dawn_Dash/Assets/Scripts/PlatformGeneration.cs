using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{

    public GameObject[] Platforms;
    float timer;

    void Start()
    {
        timer = Time.deltaTime;
        if (timer >= 0.5f)
        {
            var RandomSpawn = Random.Range(0, Platforms.Length);
            var Clone = Instantiate(Platforms[RandomSpawn], new Vector3(transform.position.x, transform.position.y, transform.position.z + 220), Quaternion.identity);
            timer = 0;
            Destroy(Clone, 20);
        }
    }
}
