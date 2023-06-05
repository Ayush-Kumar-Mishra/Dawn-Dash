using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{

    public GameObject[] Platforms;
    public int zPos = 300;
    public bool creatingSection = false;
    public int randomSpawn;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        randomSpawn = Random.Range(0, Platforms.Length);
        var Clone = Instantiate(Platforms[randomSpawn], new Vector3(0, transform.position.y, zPos), Quaternion.identity);
        zPos += 300;
        yield return new WaitForSeconds(2);
        creatingSection = false;
        
    }
}
