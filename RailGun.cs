using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailGun : MonoBehaviour
{
    float a = 0; //効果時間用
    private void Update()
    {
        a += Time.deltaTime;
        if (a > 1)     //1秒たったら効果を終了する
        {
            Destroy(this.gameObject);
        }
    }

}
