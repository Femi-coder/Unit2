using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Dog"))
        {
            // Destroy the GameObject only if it's not a "Dog"
            Destroy(gameObject);
        }
    }
}
