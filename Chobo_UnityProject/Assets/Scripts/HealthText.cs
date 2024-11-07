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

    public int health; // health ���� ������ ����

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
        MindText.text = health.ToString();
        ATKText.text = health.ToString();
        DEFText.text = health.ToString();
        SPEEDText.text = health.ToString();
        CCText.text = health.ToString();
        AVText.text = health.ToString();
        HITText.text = health.ToString();
    }

    void Update()
    {
        
    }
}
