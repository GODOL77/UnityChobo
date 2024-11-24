using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas canvas; // UI가 속한 Canvas
    private RectTransform rectTransform; // 드래그할 오브젝트의 RectTransform
    private CanvasGroup canvasGroup; // 투명도와 상호작용을 조정
    private Vector2 originalPosition; // 드래그 전 위치 저장

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        // Canvas 검색 (InventoryPanelCanvas 기준)
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // 드래그 시작 시
        originalPosition = rectTransform.anchoredPosition; // 현재 위치 저장
        canvasGroup.alpha = 0.6f; // 드래그 중 슬롯 투명하게
        canvasGroup.blocksRaycasts = false; // 드래그 중 충돌 비활성화
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 드래그 중 위치 이동
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; // Canvas 크기에 따라 위치 조정
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // 드래그 종료 시
        canvasGroup.alpha = 1f; // 투명도 복원
        canvasGroup.blocksRaycasts = true; // 다시 상호작용 가능하도록 설정

        // 드롭 실패 시 원래 위치로 복귀
        if (!eventData.pointerEnter || eventData.pointerEnter.GetComponent<Drop>() == null)
        {
            rectTransform.anchoredPosition = originalPosition;
        }
    }
}
