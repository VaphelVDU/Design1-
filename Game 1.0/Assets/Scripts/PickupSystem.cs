using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : AudioScript
{
<<<<<<< HEAD

    private void OnCollisionEnter2D(Collision2D col)
    {
        PlayPickup();
=======
    private void OnCollisionEnter2D(Collision2D pickUp)
    {
>>>>>>> master
        Destroy(gameObject);
    }
}
