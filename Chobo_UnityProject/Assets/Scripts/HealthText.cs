using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
    
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "10";
        MindText.text = "10";
        ATKText.text = "10";
        DEFText.text = "10";
        SPEEDText.text = "10";
        CCText.text = "10";
        AVText.text = "10";
        HITText.text = "10";

    }

}
