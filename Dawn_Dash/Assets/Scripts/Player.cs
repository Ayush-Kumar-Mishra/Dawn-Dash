using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed_F;
    public float speed_LR;
    float xInput;
    float timer;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        timer = Time.deltaTime;
        xInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + xInput*speed_LR, transform.position.y, transform.position.z + speed_F);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacles")
        {
            Time.timeScale = 0;
            Destroy(this.gameObject, 1);
        }
    }
}
