using UnityEngine;
using Cinemachine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    private void Start()
    {
        SwitchBoundingShape();
    }


    /// <summary>
    /// Switch the collider that cinemachine use for define the edge of the scene
    /// </summary>
    private void SwitchBoundingShape()
    {
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundConfiner).GetComponent<PolygonCollider2D>();
        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        // Call to clear the cache after there was changed in the bounding shape
        cinemachineConfiner.InvalidatePathCache();
    }
}
