using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ARIslandPlacer : MonoBehaviour
{
    public GameObject islandPrefab;
    private GameObject spawnedIsland;
    private ARRaycastManager raycastManager;

    static List<ARRaycastHit> hits = new();

    void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
    }

    void Update()
    {
        if (spawnedIsland != null) return;

        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;

        if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            spawnedIsland = Instantiate(islandPrefab, hitPose.position, hitPose.rotation);
        }
    }
}