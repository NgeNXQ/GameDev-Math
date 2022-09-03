using UnityEngine;

public class DistanceBetweenTwoPoints : MonoBehaviour
{
    [SerializeField]
    private GameObject pointA;

    [SerializeField]
    private GameObject pointB;

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
}
