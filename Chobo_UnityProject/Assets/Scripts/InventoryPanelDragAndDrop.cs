using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryPanelDragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private Vector2 originalPosition;
    private Transform originalParent;

    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = rectTransform.anchoredPosition;
        originalParent = rectTransform.parent;

        canvasGroup.alpha = 0.6f; // 드래그 중 반투명 처리
        canvasGroup.blocksRaycasts = false; // 드래그 중 다른 UI 요소와의 상호작용 무시
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        // Raycast 검출을 위한 리스트 준비
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResults);

        // 다른 InventorySpacePanel 위에 있는지 확인
        foreach (RaycastResult result in raycastResults)
        {
            if (result.gameObject.CompareTag("InventorySpacePanel") && result.gameObject != gameObject)
            {
                RectTransform targetRectTransform = result.gameObject.GetComponent<RectTransform>();
                Vector2 targetPosition = targetRectTransform.anchoredPosition;

                // 위치 교체
                targetRectTransform.anchoredPosition = originalPosition;
                rectTransform.anchoredPosition = targetPosition;
                return;
            }
        }

        // 원래 위치로 되돌리기
        rectTransform.anchoredPosition = originalPosition;
    }


}
