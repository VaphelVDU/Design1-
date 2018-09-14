using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D pickUp)
    {
        Destroy(pickUp.gameObject);
    }


}
