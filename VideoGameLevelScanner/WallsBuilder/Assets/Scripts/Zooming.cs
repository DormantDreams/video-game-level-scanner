﻿using UnityEngine;
using System.Collections;

public class Zooming : MonoBehaviour {

    public float distance = 50;
    public float sensitivityDistance = 50;
    public float damping = 10;
    public float minDistance = 5;
    public float maxDistance = 200;

    void Start()
    {
        //for percpective camera pick camera.fieldOfView
        distance = camera.orthographicSize;
    }
    void Update()
    {
        distance -= Input.GetAxis("Mouse ScrollWheel") * sensitivityDistance;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, distance, Time.deltaTime * damping);
    }
}
