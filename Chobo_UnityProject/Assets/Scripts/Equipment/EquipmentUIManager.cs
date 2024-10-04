using UnityEngine;

public class EquipmentUIManager : MonoBehaviour
{
    public GameObject equipmentPanel;  // 장비 목록 창 (Panel)

    // 장비 선택 버튼 클릭 시 호출되는 함수
    public void OnEquipmentButtonClicked()
    {
        // 장비 목록 창의 활성화 여부를 토글
        equipmentPanel.SetActive(!equipmentPanel.activeSelf);
    }
    public void CloseEquipment()
    {
        if (equipmentPanel != null)
        {
            equipmentPanel.SetActive(false);  // equipmentPanel를 비활성화
        }
    }

}
