using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerpDisplacer : MonoBehaviour
{

    // This is where my camera should end
    public Transform endMarker = null;

    // Update is called once per frame
    void Update()
    {
        if (endMarker)
        {
            transform.position = Vector3.Lerp(transform.position, endMarker.position, Time.deltaTime);
            if (Vector3.Distance(transform.position, endMarker.position) < 0.1)
                endMarker = null;
        }
    }
}
