using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class PlaceOnPlane : MonoBehaviour
{
    public GameObject solarSystemPrefab; // Prefab for the Solar System
    private ARRaycastManager raycastManager;
    private GameObject spawnedObject;

    // List to hold ARRaycastHits
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;

            // Perform the raycast
            if (raycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                // Get the first hit position
                Pose hitPose = hits[0].pose;

                // Instantiate the Solar System at the hit position
                if (spawnedObject == null)
                {
                    spawnedObject = Instantiate(solarSystemPrefab, hitPose.position, hitPose.rotation);
                }
            }
        }
    }
}