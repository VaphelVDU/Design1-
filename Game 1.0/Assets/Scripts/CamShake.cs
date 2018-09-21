using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{ 
    public Transform camTransform;
    public float shake = 0.5f;//For how long the object is shaking.
    public float shakeAmount = 0.8f; //Value shakes the camera.
    public float decreaseFactor = 1.0f;

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

    public void ShakeFunction()
    {
        camTransform.localPosition = startPos + Random.insideUnitSphere * shakeAmount;
        shake -= Time.deltaTime * decreaseFactor;
    }
}
