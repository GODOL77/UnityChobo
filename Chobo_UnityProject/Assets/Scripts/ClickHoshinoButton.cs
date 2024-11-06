using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHoshinoButton : MonoBehaviour
{
    public Button HoshinoButton; 
    public Button SwimsuitButton; 
    public Button ArmedButton; 
    public GameObject HoshinoStanding;
    public GameObject SwimsuitHoshinoStanding;
    public GameObject ArmedHoshinoStanding;

    void Start()
    {
        // 초기 상태 설정
        // 버튼 활성화
        HoshinoButton.gameObject.SetActive(true); 
        SwimsuitButton.gameObject.SetActive(true);
        ArmedButton.gameObject.SetActive(true);
        HoshinoStanding.SetActive(true);
        SwimsuitHoshinoStanding.SetActive(false);
        ArmedHoshinoStanding.SetActive(false);

        // 버튼 클릭시 이벤트 할당
        HoshinoButton.onClick.AddListener(ShowHoshino);
        SwimsuitButton.onClick.AddListener(ShowSwimsuitHoshino);
        ArmedButton.onClick.AddListener(ShowArmedHoshino);
    }

    void ShowHoshino()
    {
        HoshinoStanding.SetActive(true);
        SwimsuitHoshinoStanding.SetActive(false);
        ArmedHoshinoStanding.SetActive(false);
    }

    void ShowSwimsuitHoshino()
    {
        HoshinoStanding.SetActive(false);
        SwimsuitHoshinoStanding.SetActive(true);
        ArmedHoshinoStanding.SetActive(false);
    }

    void ShowArmedHoshino()
    {
        HoshinoStanding.SetActive(false);
        SwimsuitHoshinoStanding.SetActive(false);
        ArmedHoshinoStanding.SetActive(true);
    }
}
