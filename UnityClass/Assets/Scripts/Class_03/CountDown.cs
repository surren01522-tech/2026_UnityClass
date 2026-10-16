using UnityEngine;

public class CountDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int count = 5;

        while (count > 1)
        {
            count--;
            Debug.Log("카운트다운:" + count);
        }
        Debug.Log("카운트 다운 완료");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
