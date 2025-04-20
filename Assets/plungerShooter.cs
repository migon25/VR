using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plungerShooter : MonoBehaviour
{
    public GameObject plungerPrefab;
    public Transform shootPoint;
    public float shootForce = 500f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GameObject plunger = Instantiate(plungerPrefab, shootPoint.position, shootPoint.rotation);
            Rigidbody rb = plunger.GetComponent<Rigidbody>();
            rb.AddForce(shootPoint.forward * shootForce);
        }
    }
}
