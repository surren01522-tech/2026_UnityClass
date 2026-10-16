using UnityEngine;

public class Attack : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int mosterHp = 30;
        int attackPower = 10;

        while (mosterHp > 0)
        {
            Debug.Log("몬스터를 공격했습니다 데미지:" + attackPower);
            mosterHp -= attackPower;
            Debug.Log("남은 몬스터 체력:" +  mosterHp);
        }

        Debug.Log("몬스터 처지 완료"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
