using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("Gun")]
    public float firerate = 0.1f;
    public float cooldown = 0f;
    public float spread = 5f;
    public GameObject projectilePrefab;

    public Transform point;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            if (Input.GetButton("Fire1"))
            {
                if (CanFireGun())
                {
                    FireGun();
                }
            }

            if (cooldown > 0)
                cooldown -= Time.deltaTime;
        }
    }

    private void FireGun()
    {
        Instantiate(projectilePrefab, point.position, AngleWithSpread(spread));
        cooldown = firerate;
    }

    private bool CanFireGun()
    {
        return cooldown < 0;
    }

    private Quaternion AngleWithSpread(float spread)
    {
        return (point.rotation * Quaternion.Euler(0, 0, Random.Range(-spread, spread)));
    }
}
