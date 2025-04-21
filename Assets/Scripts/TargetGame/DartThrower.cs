using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DartThrower : MonoBehaviour
{
    public GameObject dartPrefab;
    public Transform arCameraTransform;
    public float throwForce = 500f;

    public Vector3 rotationOffset = new Vector3(0f, 0f, 0f);

    public void ThrowDart()
    {
        Quaternion offsetRotation = Quaternion.Euler(rotationOffset);
        Quaternion dartRotation = arCameraTransform.rotation * offsetRotation;

        GameObject dart = Instantiate(dartPrefab, arCameraTransform.position, dartRotation);
        Rigidbody rb = dart.GetComponent<Rigidbody>();
        rb.AddForce(arCameraTransform.forward * throwForce);
        Destroy(dart, 2.5f);
    }
}