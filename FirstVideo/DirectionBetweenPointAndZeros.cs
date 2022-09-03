using UnityEngine;

public sealed class DirectionBetweenPointAndZeros : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Vector2 currentPosition = this.transform.position;
        Gizmos.DrawLine(Vector2.zero, currentPosition.normalized);
    }
}
