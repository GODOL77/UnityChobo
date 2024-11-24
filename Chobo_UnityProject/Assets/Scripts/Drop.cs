using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // 드래그 중인 오브젝트 가져오기
        GameObject droppedObject = eventData.pointerDrag;

        if (droppedObject != null && droppedObject.GetComponent<DragAndDrop>() != null)
        {
            // 드롭된 오브젝트를 슬롯 위치로 이동
            RectTransform droppedRect = droppedObject.GetComponent<RectTransform>();
            droppedRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            Debug.Log($"'{droppedObject.name}'가 '{gameObject.name}'에 드롭되었습니다!");
        }
    }
}
