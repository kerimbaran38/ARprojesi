using UnityEngine;

public class OrbitPlanet : MonoBehaviour
{
    public Transform sun; // Reference to the Sun's Transform
    public float orbitSpeed = 10f; // Orbital velocity (same for all planets)

    void Update()
    {
        if (sun != null)
        {
            // Rotate around the Sun at a constant speed
            transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }
}