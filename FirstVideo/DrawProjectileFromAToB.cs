using UnityEngine;

public sealed class DrawProjectileFromAToB : MonoBehaviour
{
    [SerializeField]
    private GameObject pointA;

    [SerializeField]
    private GameObject pointB;

    [SerializeField]
    [Range(0.0f, 10.0f)]
    private float speed;

    private void OnDrawGizmos()
    {
        Vector2 aToB = (pointB.transform.position - pointA.transform.position).normalized;

        Gizmos.DrawLine(pointA.transform.position, (Vector2)pointA.transform.position + aToB);

        //Gizmos.DrawSphere((pointA.transform.position + pointB.transform.position) / 2, 0.25f);

        Gizmos.DrawSphere((Vector2)pointA.transform.position + aToB * speed, 0.25f);
    }
}
