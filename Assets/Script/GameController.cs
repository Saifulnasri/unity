using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool isActive = false; // ตัวแปรนี้ไม่ได้ใช้ในโค้ดนี้
    public GameObject startGroup;
    private bool isStart = false; // ประกาศตัวแปรที่ขาดไป

    void Start()
    {
        startGroup.SetActive(true); // ใช้ SetActive เป็นเมธอด
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            startGroup.SetActive(false);
        }
    }

    // เปลี่ยนชื่อฟังก์ชันให้ชัดเจน
    public void TriggerStart()
    {
        isStart = true;
    }
}
