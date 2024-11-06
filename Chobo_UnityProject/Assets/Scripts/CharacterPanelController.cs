using UnityEngine;

public class CharacterPanelController : MonoBehaviour {
    // CharacterPanels 패널을 참조할 변수
    public GameObject CharacterPanels;

    // CharacterHead 클릭 시 CharacterPanels 활성화
    public void ShowCharacterPanels() 
    {
        CharacterPanels.SetActive(true);
        Debug.Log("ㅇㅇㅇㅇ");
    }

    // CloseCharacterPanel 클릭 시 CharacterPanels 비활성화
    public void HideCharacterPanels() 
    {
        CharacterPanels.SetActive(false);
        Debug.Log("ㄴㄴㄴㄴ");
    }
}
