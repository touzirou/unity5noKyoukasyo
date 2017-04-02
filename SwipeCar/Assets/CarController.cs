using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 車を動かすよ
 * @author tsujimochi
 */
public class CarController : MonoBehaviour
{

    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        // nothing
    }

    void Update()
    {
        // マウスがクリックされたら初速度を設定
        //if(Input.GetMouseButtonDown(0))
        //{
        //    this.speed = 0.2f;
        //}

        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // マウスを離した座標
            Vector2 endPost = Input.mousePosition;
            float swipeLength = (endPost.x - this.startPos.x);

            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 1000.0f;

            // 効果音再生
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0); // 移動
        this.speed = this.speed * 0.98f;  // 減速
    }
}
