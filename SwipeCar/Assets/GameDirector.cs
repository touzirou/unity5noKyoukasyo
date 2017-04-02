using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI部品を使うために必要！

/**
 * 距離情報を表示するよ
 * @author tsujimochi
 */
public class GameDirector : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // 車と旗までの距離を計算
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if(length >= 0)
        {
            this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
        }else
        {
            this.distance.GetComponent<Text>().text = "ゲームオーバー";
        }

    }
}
