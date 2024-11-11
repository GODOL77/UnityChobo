using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterPanelDragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
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
        GameObject target = eventData.pointerEnter;

        // 드래그가 끝난 후 다른 CharacterPanel 위에 있으면 위치 교체
        if (target != null && target.CompareTag("CharacterPanel") && target != gameObject)
        {
            RectTransform targetRectTransform = target.GetComponent<RectTransform>();
            Vector2 targetPosition = targetRectTransform.anchoredPosition;

            // 위치 교체
            targetRectTransform.anchoredPosition = originalPosition;
            rectTransform.anchoredPosition = targetPosition;
        }
        else
        {
            rectTransform.anchoredPosition = originalPosition;
        }

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
}
