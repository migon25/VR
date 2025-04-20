using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHit : MonoBehaviour
{
    public GameManager gameManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plunger")
        {
            gameManager.AddScore(1);
            Destroy(gameObject);
        }
    }
}
