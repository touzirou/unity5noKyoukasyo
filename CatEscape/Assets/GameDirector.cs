using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * UIを監督するよ
 * @author tsujimochi
 */
public class GameDirector : MonoBehaviour {

    GameObject hpGage;

	void Start () {
        this.hpGage = GameObject.Find("hpGage");
	}

    void Update()
    { 
        if(this.hpGage.GetComponent<Image>().fillAmount <= 0)
        {
            GameObject text = GameObject.Find("Text");
            text.GetComponent<Text>().text = "ゲームオーバー";
        }
    }

	public void DecreaseHp () {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
