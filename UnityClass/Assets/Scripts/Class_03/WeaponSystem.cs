using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int weaponID = 2;

        switch (weaponID)
        {
            case 1:
                Debug.Log("장착 무기: 낡은 검");
                break;
            case 2:
                Debug.Log("장착 무기: 강철 장궁");
                break;
            case 3:
                Debug.Log("무기가 선택되지않았습니다");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
