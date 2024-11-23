using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterInfoController : MonoBehaviour, IPointerClickHandler
{
    public GameObject characterInfo; // 연결할 CharacterInfo 오브젝트

    void Start()
    {
        if (characterInfo != null)
        {
            characterInfo.SetActive(false); // 시작 시 비활성화
        }
    }

    // IPointerClickHandler를 사용하여 클릭 이벤트 처리
    public void OnPointerClick(PointerEventData eventData)
    {
        // 우클릭일 때 처리
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (characterInfo != null)
            {
                // CharacterInfo 활성화
                characterInfo.SetActive(true);
            }
        }
    }
}
