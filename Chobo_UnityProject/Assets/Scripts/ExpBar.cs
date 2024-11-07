using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Slider expBar;
    public int currExp;
    public int[] maxExp = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    public int index;
    // Start is called before the first frame update
    void Start()
    {
    }   

    // Update is called once per frame
    void Update()
    {
        Refresh();
    }

    // ExpBar 구동
    void Refresh()
    {
        while(index > maxExp.Length)
        {
            expBar.value = (float)(currExp -maxExp[index-1]) /maxExp[index];
            
        }
    }
}