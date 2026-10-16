using UnityEngine;

public class DifficultySelect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int difficulty = 3;

        switch (difficulty)
        {
            case 1:
                Debug.Log("난이도 쉬움 (쉬운 몬스터 생성)");
                break;
            case 2:
                Debug.Log("난이도 보통 (일반 몬스터 생성");
                break;
            case 3:
                Debug.Log("난이도 어려움 (보스 몬스터 생성)");
                break;
            default:
                Debug.Log("잘못된 난이도 선택입니다");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
