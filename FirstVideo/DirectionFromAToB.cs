using UnityEngine;

public sealed class DirectionFromAToB : MonoBehaviour
{
    [SerializeField]
    private GameObject pointA;

    [SerializeField]
    private GameObject pointB;

    private void OnDrawGizmos()
    {
        Vector2 fromAToB = (pointB.transform.position - pointA.transform.position).normalized;

        Gizmos.DrawLine(pointA.transform.position, (Vector2)pointA.transform.position + fromAToB);
    }
}
