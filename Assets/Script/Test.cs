using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f; // ความเร็วในการเคลื่อนที่
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        // รับค่าการกดปุ่มลูกศรหรือปุ่ม W, A, S, D
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // สร้างเวกเตอร์การเคลื่อนที่
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // เคลื่อนที่ตัวละครตามทิศทางและความเร็วที่กำหนด
        rb.velocity = movement * speed;
    }
}
