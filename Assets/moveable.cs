using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class moveable : MonoBehaviour
{
    public float speed = 2.0f; 

    void Update()
    {

        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.localPosition = Vector3.Lerp(new Vector3(0, 0.3f, 0), new Vector3(0, -0.3f, 0), time);
    }
}
