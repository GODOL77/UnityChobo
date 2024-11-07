using System;
using UnityEngine;
using UnityEngine.UI;
public class HpBar : MonoBehaviour
{
    public Slider hpBar;
    public int currHp;
    public int maxHp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Refresh();
    }

    void Refresh()
    {
        hpBar.value = (float)currHp / maxHp;
        if(hpBar.value == 0)
        {
        transform.Find("Fill Area").gameObject.SetActive(false);
        }
        else
        {
    transform.Find("Fill Area").gameObject.SetActive(true);
        }
    }

// 데미지 딸깍
    public void TakeDamage(int damage)
    {
        if(currHp < 1)
        {
            Debug.Log("저런 디졌네요");
            damage = 0;
        }
        else
        {
            if (currHp - damage < 0)
            {
                currHp = damage;
            }
                Debug.Log("HP를 감소합니다.");
        }
        currHp -= damage;
    }

    // 힐링 딸깍
    public void TakeHealing(int heal)
    {
        if(currHp < 1 || currHp > maxHp - 1)
        {
            Debug.Log("저런 힐을 할수 없네");
            heal = 0;
        }
        else
        {
            if (currHp + heal > maxHp)
            {
                currHp = maxHp - heal;
            }
            Debug.Log("HP를 회복 합니다.");
        }
        currHp += heal;
    }

    // 체력 원복
    public void ResetDamage()
    {
        Debug.Log("HP를 원상복구 합니다.");
        currHp = maxHp;
    }
}
