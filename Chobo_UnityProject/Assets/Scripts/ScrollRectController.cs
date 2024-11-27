using UnityEngine;
using UnityEngine.UI;

public class ScrollRectController : MonoBehaviour
{
    public ScrollRect scrollRect; // ScrollRect 컴포넌트
    public float scrollSpeed = 0.1f; // 스크롤 속도 조절

    void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            // 스크롤 휠 입력 감지 후 ScrollRect 이동
            scrollRect.verticalNormalizedPosition += Input.mouseScrollDelta.y * scrollSpeed;
        }
    }
}
