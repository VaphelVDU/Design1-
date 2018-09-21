using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : AudioScript
{

    private void OnCollisionEnter2D(Collision2D col)
    {
        PlayPickup();
        Destroy(gameObject);
    }
}
