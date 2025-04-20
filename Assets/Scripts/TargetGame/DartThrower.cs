using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DartThrower : MonoBehaviour
{
    public GameObject dartPrefab;
    public Transform arCameraTransform;
    public float throwForce = 500f;

    public void ThrowDart()
    {
        GameObject dart = Instantiate(dartPrefab, arCameraTransform.position, arCameraTransform.rotation);
        Rigidbody rb = dart.GetComponent<Rigidbody>();
        rb.AddForce(arCameraTransform.forward * throwForce);
        Destroy(dart, 2.5f);
    }
}
