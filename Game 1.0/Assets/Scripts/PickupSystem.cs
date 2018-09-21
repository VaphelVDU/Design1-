using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D pickUp)
    {
        Destroy(gameObject);
    }


}
