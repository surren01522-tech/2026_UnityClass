using UnityEngine;

public class PotionGift : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int potionCount = 0;

        for (int i = 1; i <= 5; i++)
        {
            potionCount++;
            Debug.Log(i + "번째 포션을 지급했습니다. (현재 포션: " + potionCount + "개)"); 
        }

        Debug.Log("포션 지급이 완료되었습니다 ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
