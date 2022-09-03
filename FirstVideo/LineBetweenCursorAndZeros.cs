using UnityEngine;

public sealed class LineBetweenCursorAndZeros : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Vector2.zero, this.transform.position);
    }
}
