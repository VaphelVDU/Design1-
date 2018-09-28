using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : CamShake
{
    public GameObject bullet;
    private GameObject b;

    public void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
<<<<<<< HEAD
=======
            ShakeFunction();
>>>>>>> master
            b = (GameObject)(Instantiate(bullet, transform.position + transform.right * 1.5f, Quaternion.identity));
            b.GetComponent<Rigidbody2D>().AddForce(transform.right * 700);
        }
        
    }

}
