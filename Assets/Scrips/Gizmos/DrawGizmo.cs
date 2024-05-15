using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo : MonoBehaviour
{
    [SerializeField] private Transform[] controlpoints;
    private Vector3 gizmopointspotition;
    private void OnDrawGizmos()
    {
        for (float t = 0; t <= 1; t += 0.05f)
        {
            gizmopointspotition = Mathf.Pow(1 - t, 3) * controlpoints[0].position +
               3 * Mathf.Pow(1 - t, 2) * t * controlpoints[1].position +
               3 * (1 - t) * Mathf.Pow(t, 2) * controlpoints[2].position +
               Mathf.Pow(t, 3) * controlpoints[3].position;
            Gizmos.DrawSphere(gizmopointspotition, 0.2F);
        }
        Gizmos.DrawLine(new Vector3(controlpoints[0].position.x, controlpoints[0].position.y, 0f),
                    new Vector3(controlpoints[1].position.x, controlpoints[1].position.y, 0f));
        Gizmos.DrawLine(new Vector3(controlpoints[2].position.x, controlpoints[2].position.y, 0f),
                    new Vector3(controlpoints[3].position.x, controlpoints[3].position.y, 0f));
    }

}
