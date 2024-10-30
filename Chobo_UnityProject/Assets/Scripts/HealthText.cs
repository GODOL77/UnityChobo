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

    private int health; // health ���� ������ ����

    // Start is called before the first frame update
    void Start()
    {
        health = 10; // �ʱ�ȭ�� health �� ����
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
        // ���콺 ���� ��ư�� Ŭ���Ǿ��� ��
        if (Input.GetMouseButtonDown(0))
        {
            health += 100; // health ���� 10 ����
            healthText.text = health.ToString(); // ������ ���� �ؽ�Ʈ�� ��ȯ�Ͽ� ǥ��
        }
    }
}
