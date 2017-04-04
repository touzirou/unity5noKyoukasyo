using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * アイテム落ちるよ
 * @author tsujimochi
 */
public class ItemController : MonoBehaviour
{

    public float dropSpeed = -0.03f;

    void Start()
    {
        // nothing
    }

    void Update()
    {
        transform.Translate(0, this.dropSpeed, 0);
        if (transform.position.y < -0.1f)
        {
            Destroy(gameObject);
        }
    }
}
