using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : AudioScript
{
    public AudioSource pickupSource;
    public AudioClip pickupClip;

    private void OnCollisionEnter2D(Collision2D col)
    {
        PlaySound(pickupSource, pickupClip);
        Destroy(gameObject);
    }

}
