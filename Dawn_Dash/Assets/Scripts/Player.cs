using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed_F;
    public float speed_LR;
    float xInput;

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + xInput*speed_LR, transform.position.y, transform.position.z + speed_F);
    }
}
