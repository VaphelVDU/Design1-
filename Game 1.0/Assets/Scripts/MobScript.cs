using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;



    void Start()
    {

        transform.position = new Vector3(0.0f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        float mobX = GameObject.transform.position.x();
        float mobZ = GameObject.transform.position.z();
    }
}
