using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyAfterDelay(5f)); // เริ่ม Coroutine เพื่อทำลายลูกบอลหลังจาก 5 วินาที
    }

    IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // รอเวลา delay วินาที

        Destroy(gameObject); // ทำลายลูกบอล
    }
}

