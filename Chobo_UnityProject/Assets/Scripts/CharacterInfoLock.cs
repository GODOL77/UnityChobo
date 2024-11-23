using UnityEngine;

public class CharacterInfoLock : MonoBehaviour
{
    private Vector3 initialWorldPosition; // CharacterInfo의 초기 월드 좌표 저장
    private Transform characterInfoTransform; // CharacterInfo Transform 참조

    void Start()
    {
        // CharacterPanel의 자식인 CharacterInfo를 찾음
        characterInfoTransform = transform.Find("CharacterInfo");

        if (characterInfoTransform != null)
        {
            // CharacterInfo의 초기 월드 좌표를 저장
            initialWorldPosition = characterInfoTransform.position;
        }
        else
        {
            Debug.LogError("CharacterInfo not found as child of " + gameObject.name);
        }
    }

    void LateUpdate()
    {
        if (characterInfoTransform != null)
        {
            // 부모 이동과 관계없이 CharacterInfo의 월드 좌표를 초기 월드 좌표로 고정
            characterInfoTransform.position = initialWorldPosition;
        }
    }
}
