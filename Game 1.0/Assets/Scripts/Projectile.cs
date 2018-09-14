using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public Transform Spawnpoint;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D clone;

            clone = (Rigidbody2D)Instantiate(projectile, Spawnpoint.position, projectile.rotation);

            clone.velocity = Spawnpoint.TransformDirection(Vector2.forward * 20);
        }
    }
}
