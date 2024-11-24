using UnityEngine;
using UnityEngine.UI; // Button을 사용하기 위해 추가

public class InventoryController : MonoBehaviour
{
    // InvenrotyPanels 패널을 참조할 변수
    public GameObject InventoryUI;

    // InventoryCloseButton을 참조할 변수
    public Button InventoryCloseButton;

    // InventoryHead 클릭 시 InventoryPanels 활성화
    public void ShowInventoryPanels()
    {
        InventoryUI.SetActive(true);
        Debug.Log("ㅇㅇㅇㅇ");
    }

    // CloseInventoryPanel 클릭 시 InventoryPanels 비활성화
    public void HideInventoryPanels()
    {
        InventoryUI.SetActive(false);
        Debug.Log("ㄴㄴㄴㄴ");
    }

    // Update에서 키 입력을 처리하는 부분
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryUI.activeSelf)
            {
                HideInventoryPanels();
            }
            else
            {
                ShowInventoryPanels();
            }
        }
    }

    // Start에서 버튼 클릭 이벤트 설정
    void Start()
    {
        // 버튼에 이벤트 추가
        if (InventoryCloseButton != null)
        {
            InventoryCloseButton.onClick.AddListener(HideInventoryPanels);
        }
    }
}
