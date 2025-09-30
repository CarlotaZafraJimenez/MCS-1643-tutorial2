using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 12.0f;
    public KeyCode upKey;
    public KeyCode downKey;
    public float maxZ = 9.0f;

    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.Position += new Vector3(0, 0, speed * Time.deltaTime);
            if (tranform.position.z > maxZ)
            {
                Transform.position = new Vector3(
                transform.position.x, transform.position.y, maxZ);
            }
        }
        else if (Input.GetKey(downKey))
        {
            transform.position + new Vector3(0, 0, -1 * speed * Time.deltaTime);
            if (tranform.position.z < -1 * maxZ)
            {
                transform.position = new Vector3(
                transform.position.x, transform.position.y, -1 * maxZ);
            }

        }

    }
}
