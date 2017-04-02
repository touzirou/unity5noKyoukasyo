using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * ルーレットのスクリプト
 * @author tsujimochi
 */
public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0; // 回転速度

    // 起動時に一度だけ実行
    void Start()
    {

    }

    // フレーム毎に実行
    void Update()
    {
        // マウスが押されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 5;
        }

        // 回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        // ルーレットを減速させる
        this.rotSpeed = this.rotSpeed * 0.96f;
    }
}
