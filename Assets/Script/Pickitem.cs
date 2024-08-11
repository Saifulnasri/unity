using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickitem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Football"))
        {
            Destroy(target.gameObject);
            //ตัวแปร score นับสกอร์ทีละ 10 คะแนน
            score += 10;
            Debug.Log(score);
            scoreText.text = "Score ="+score.ToString();
        }
    }
}
