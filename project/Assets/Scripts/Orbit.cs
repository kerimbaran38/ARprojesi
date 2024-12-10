using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform center;
    public float orbitSpeed = 10f;

    void Update()
    {
        transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
