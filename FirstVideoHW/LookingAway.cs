using UnityEngine;

public sealed class LookingAway : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    [SerializeField]
    [Range(-1.0f, 0.0f)]
    private float pseudoAngle = -0.5f;

    private void OnDrawGizmos()
    {
        Vector2 playerToItem = (item.transform.position - this.transform.position).normalized;

        Gizmos.color = Color.white;
        Gizmos.DrawLine(this.transform.position, playerToItem + (Vector2)this.transform.position);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, this.transform.right + this.transform.position);

        if(Vector2.Dot(this.transform.right, playerToItem) <= pseudoAngle)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(this.transform.position, this.transform.right + this.transform.position);
        }
    }
}
