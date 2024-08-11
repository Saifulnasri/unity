using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ccoin"))
        {
            // ทำให้บล็อคสี่เหลี่ยมหายไป
            Destroy(other.gameObject);
        }
    }
}