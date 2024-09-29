using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour
{
    public Image equipmentIcon;  // 장비 아이콘을 표시할 Image
    public Button slotButton;    // 장비 슬롯 버튼

    // 장비 선택 시 호출되는 함수
    public void OnSlotClicked(Sprite selectedIcon, string equipmentName)
    {
        // 장비 아이콘과 이름을 UI에 업데이트
        equipmentIcon.sprite = selectedIcon;
        Debug.Log(equipmentName + "이(가) 선택되었습니다.");
        
        // 추가적으로 선택된 장비를 실제로 장착하는 로직
    }
}