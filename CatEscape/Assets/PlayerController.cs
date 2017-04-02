using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * キー操作でプレイヤーを動かすよ
 * @author tsujimochi
 */
public class PlayerController : MonoBehaviour
{

    void Start()
    {

    }

    //void Update()
    //{
    //    // 左矢印が押された時
    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-3, 0, 0); // 左に「3」動かす
    //    }

    //    // 右矢印が押された時
    //    if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        transform.Translate(3, 0, 0); // 右に「3」動かす
    //    }
    //}

    public void LButtonDown()
    {
        if(transform.position.x <= -8)
        {
            return;
        }
        transform.Translate(-2, 0, 0);
    }

    public void RButtonDown()
    {
        if(transform.position.x >= 8)
        {
            return;
        }
        transform.Translate(2, 0, 0);
    }
}
