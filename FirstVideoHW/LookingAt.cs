using UnityEngine;

public sealed class LookingAt : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    [SerializeField]
    [Range(0.0f, 1.0f)]
    private float angle = 0.5f;

    private void OnDrawGizmos()
    {
        Vector2 playerToItem = (item.transform.position - this.transform.position).normalized;

        Gizmos.color = Color.white;
        Gizmos.DrawLine(this.transform.position, playerToItem + (Vector2)this.transform.position);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.right);

        if (Vector2.Dot(playerToItem, this.transform.right) >= angle)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.right);
        }
    }
}
