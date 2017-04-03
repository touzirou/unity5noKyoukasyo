using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * イガグリ飛ばしますか？
 * @author tsujimochi
 */
public class IgaguriController : MonoBehaviour
{

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }


    void Start()
    {
        // Shoot(new Vector3(0, 200, 2000));
    }

    void Update()
    {

    }
}
