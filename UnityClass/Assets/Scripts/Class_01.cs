using UnityEngine;

public class Class_01 : MonoBehaviour
{
    int level = 1;
    float damage = 1.5f;
    string palyer = "플레이어";
    bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ( level >= 1)
        {
            level = 2;
        }
        if (damage == 2.0f)
        {
            damage = 5.5f;
        }

        Debug.Log("변경된 레벨:" + level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
