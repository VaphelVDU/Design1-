using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour {

    public Transform camTransform;
    public float shake = 0.5f;//For how long the objekt is shaking.
    public float shakeAmount = 0.8f; //Value shakes the camera.
    public float decreaseFactor = 1.0f;
    public int health;
    public int damageAmount;

    Vector3 startPos;

    private void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    private void OnEnable()
    {
        startPos = camTransform.localPosition;
    }

    private void Update()
    {
        if (shake > 0)
        {
            camTransform.localPosition = startPos + Random.insideUnitSphere * shakeAmount;
            shake -= Time.deltaTime * decreaseFactor;
        }

        else
        {
            shake = 0f;
            startPos = camTransform.localPosition;
        }
    }
}


