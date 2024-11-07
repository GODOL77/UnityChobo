using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStart : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {      //마우스 좌클릭시 (0 : 좌클릭, 1 : 휠 클릭, 2 : 우클릭)
            SceneManager.LoadScene("MainMenu"); //메인메뉴로 이동
        }
    }
}
