using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject bullet;

    public void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject b = (GameObject)(Instantiate(bullet, transform.position + transform.up * 1.5f, Quaternion.identity));
            b.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
        }
    }

}
