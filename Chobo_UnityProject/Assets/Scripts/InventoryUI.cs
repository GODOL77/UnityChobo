using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject InventorySlot; // 슬롯 프리팹
    public Transform content;        // Content 영역
    public int totalSlots = 50;      // 총 슬롯 개수
    public int columns = 5;          // 한 줄에 들어갈 슬롯 개수
    public Vector2 slotSize = new Vector2(100, 175); // 슬롯 크기
    public float spacing = 10f;      // 슬롯 간 간격

    void Start()
    {
        GenerateSlots();
        AdjustContentSize();
    }

    void GenerateSlots()
    {
        // 슬롯 생성
        for (int i = 0; i < totalSlots; i++)
        {
            GameObject slot = Instantiate(InventorySlot, content);
            slot.name = "Slot_" + (i + 1); // 슬롯 이름 설정
        }
    }

    void AdjustContentSize()
    {
        RectTransform contentRect = content.GetComponent<RectTransform>();
        int rows = Mathf.CeilToInt((float)totalSlots / columns); // 필요한 행 계산

        // Content 크기 조정 (슬롯 크기 + 간격)
        contentRect.sizeDelta = new Vector2(
            contentRect.sizeDelta.x,
            rows * (slotSize.y + spacing) - spacing // 마지막 줄 간격을 제외
        );
    }

}
