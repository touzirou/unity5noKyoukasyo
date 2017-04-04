using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * バスケット動かす
 * @author tsujimochi
 */
public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;
    GameObject director;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("キャッチ！");
        switch (other.gameObject.tag)
        {
            case "Apple":
                // Debug.Log("Tag=Apple");
                this.aud.PlayOneShot(this.appleSE);
                this.director.GetComponent<GameDirector>().GetApple();
                break;
            case "Bomb":
                // Debug.Log("Tag=Bomb");
                this.aud.PlayOneShot(this.bombSE);
                this.director.GetComponent<GameDirector>().GetBomb();
                break;
            default:
                Debug.Log("Unknown");
                break;
        }
        Destroy(other.gameObject);
    }


    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0.0f, z);
            }
        }
    }
}
