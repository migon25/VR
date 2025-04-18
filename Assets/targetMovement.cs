using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMovement : MonoBehaviour
{
    public float radius = 0.3f;
    public float speed = 50f;

    void Update()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, speed * Time.deltaTime);
    }
}
