using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class DestroyObject : MonoBehaviour
{

    ARRaycastManager m_RaycastManager;
    public TargetSpawner spawner;
    void Awake()
    {
        m_RaycastManager = GetComponent<ARRaycastManager>();
    }
    private void Update()
    {
        if (Pointer.current != null && Pointer.current.press.isPressed)
        {
            Debug.Log("destroyed");
            Destroy(gameObject);
            spawner.StartCoroutine(spawner.RespawnTarget());

        }
    }
}
 