using UnityEngine;

public class CameraBoundaryVisualizer : MonoBehaviour
{
    public Camera mainCamera;
    public float distance = 10f;

    void OnDrawGizmos()
    {
        if (mainCamera == null) return;

        Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 bottomRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, distance));
        Vector3 topLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, distance));
        Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, distance));

        Gizmos.color = Color.green;

        Gizmos.DrawLine(bottomLeft, bottomRight);
        Gizmos.DrawLine(bottomRight, topRight);
        Gizmos.DrawLine(topRight, topLeft);
        Gizmos.DrawLine(topLeft, bottomLeft);
    }
}
