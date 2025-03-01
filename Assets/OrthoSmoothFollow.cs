﻿using UnityEngine;
using System.Collections;

public class OrthoSmoothFollow : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 followOffset;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 goalPos = target.position;
        goalPos += followOffset;
        goalPos.y = transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
    }
}