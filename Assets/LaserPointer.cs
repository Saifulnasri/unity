using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    public Transform laserOrigin;
    public LineRenderer laserLineRenderer;
    public float laserMaxLength = 5f;

    void Update()
    {
        RaycastHit hit;
        Vector3 endPosition = laserOrigin.position + (laserOrigin.forward * laserMaxLength);

        if (Physics.Raycast(laserOrigin.position, laserOrigin.forward, out hit, laserMaxLength))
        {
            endPosition = hit.point;
        }

        laserLineRenderer.SetPosition(0, laserOrigin.position);
        laserLineRenderer.SetPosition(1, endPosition);
    }
}