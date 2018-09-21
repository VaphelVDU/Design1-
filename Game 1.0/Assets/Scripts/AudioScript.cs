using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource pickupSource;
    public AudioClip pickupSound;

    public virtual void PlayPickup()
    {
        pickupSource.PlayOneShot(pickupSound);
    }
}
