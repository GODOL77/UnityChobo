using UnityEngine;

public class MainHall_Popup : MonoBehaviour
{
    // 팝업 창 GameObject를 참조할 변수
    public GameObject popupPanel;

    // 팝업창을 보여주는 메서드
    public void ShowPopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);  // GameObject를 활성화
        }
        else
        {
            Debug.LogError("popupPanel is not assigned!");
        }
    }

    // 팝업창을 숨기는 메서드
    public void ClosePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false);  // GameObject를 비활성화
        }
        else
        {
            Debug.LogError("popupPanel is not assigned!");
        }
    }
}