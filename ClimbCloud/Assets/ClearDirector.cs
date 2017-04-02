using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene を使うために必要!!

/**
 * シーンを繊維させるよ
 * @author tsujimochi
 */
public class ClearDirector : MonoBehaviour {

	void Start () {	
	}

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
	}
}
