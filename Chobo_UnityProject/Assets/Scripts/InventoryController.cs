using UnityEngine;

public class InventoryController : MonoBehaviour
{
    // InvenrotyPanels 패널을 참조할 변수
    public GameObject InventoryPanels;

    // InventoryHead 클릭 시 InventoryPanels 활성화
    public void ShowInventoryPanels()
    {
        InventoryPanels.SetActive(true);
        Debug.Log("ㅇㅇㅇㅇ");
    }

    // CloseInventoryPanel 클릭 시 InventoryPanels 비활성화
    public void HideInventoryPanels()
    {
        InventoryPanels.SetActive(false);
        Debug.Log("ㄴㄴㄴㄴ");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryPanels.activeSelf)
            {
                HideInventoryPanels();
            }
            else
            {
                ShowInventoryPanels();
            }
        }
    }
}
