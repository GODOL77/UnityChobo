using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusText : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI MindText;
    public TextMeshProUGUI ATKText;
    public TextMeshProUGUI DEFText;
    public TextMeshProUGUI SPEEDText;
    public TextMeshProUGUI CCText;
    public TextMeshProUGUI ERText;
    public TextMeshProUGUI CDText;
    public TextMeshProUGUI CCresText;
    public TextMeshProUGUI ImmText;

    public int health; // health 값
    public int mind;   // mind 값
    public int atk;    // attack 값
    public int def;    // defense 값
    public int speed;  // speed 값
    public int ccres;  // CC resistance 값
    public int imm;    // Immune 값
    public int er;
    public int cc;
    public int cd;

    // Start is called before the first frame update
    void Start()
    {
        // 기본값 설정
        HealthText.text = health.ToString();
        MindText.text = mind.ToString(); // mind 값 표시
        ATKText.text = atk.ToString();   // attack 값 표시
        DEFText.text = def.ToString();   // defense 값 표시
        SPEEDText.text = speed.ToString(); // speed 값 표시
        CCText.text = ccres.ToString();  // CC 값 표시
        ERText.text = er.ToString();      // av 값 표시
        CDText.text = cd.ToString(); //cd 값 표시
        ImmText.text = imm.ToString(); //Imm 값 표시
        CCresText.text = ccres.ToString();
    }

    void Update()
    {
        // Update 로직을 추가하려면 여기에 값을 갱신하는 코드를 넣을 수 있습니다.
    }
}
