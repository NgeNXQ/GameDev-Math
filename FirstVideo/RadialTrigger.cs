using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    [Range(0.0f, 10.0f)]
    private float radius;

    private void OnDrawGizmos()
    {
        Vector2 playerToTrigger = this.transform.position - player.transform.position;

        Gizmos.color = Color.white;

        Gizmos.DrawLine(player.transform.position, (Vector2)player.transform.position + playerToTrigger.normalized);

        Gizmos.DrawSphere(this.transform.position, radius);

        if(playerToTrigger.sqrMagnitude <= radius * radius)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(this.transform.position, radius);
        }
    }
}
