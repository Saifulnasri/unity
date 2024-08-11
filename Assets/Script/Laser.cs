using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
      private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has the tag "Football"
        if (other.CompareTag("Football"))
        {
            // Make the football disappear by deactivating it
            other.gameObject.SetActive(false);
        }
    }
}
