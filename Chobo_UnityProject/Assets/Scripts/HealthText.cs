using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI MindText;
    public TextMeshProUGUI ATKText;
    public TextMeshProUGUI DEFText;
    public TextMeshProUGUI SPEEDText;
    public TextMeshProUGUI CCText;
    public TextMeshProUGUI AVText;
    public TextMeshProUGUI HITText;
    public Button TestButton;

    private int health; // health 값을 저장할 변수

    // Start is called before the first frame update
    void Start()
    {
        health = 10; // 초기화된 health 값 설정
        healthText.text = health.ToString();
        MindText.text = "10";
        ATKText.text = "10";
        DEFText.text = "10";
        SPEEDText.text = "10";
        CCText.text = "10";
        AVText.text = "10";
        HITText.text = "10";
    }

    void Update()
    {
        // 마우스 왼쪽 버튼이 클릭되었을 때
        if (Input.GetMouseButtonDown(0))
        {
            health += 10; // health 값을 10 증가
            healthText.text = health.ToString(); // 증가된 값을 텍스트로 변환하여 표시
        }
    }
}
