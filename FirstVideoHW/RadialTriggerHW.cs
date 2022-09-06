using UnityEngine;

public class RadialTriggerHW : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    [Range(0.0f, 10.0f)]
    private float radius = 1.0f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(this.transform.position, radius);         //Trigger

        Vector2 playerToTrigger = this.transform.position - player.transform.position;      //Vector from player to trigger

        Gizmos.DrawLine(player.transform.position, (Vector2)player.transform.position + playerToTrigger.normalized);    //Normilized vector from player to trigger

        if(playerToTrigger.sqrMagnitude <= radius * radius)     //Checking wheather playes is in radius of trigger
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(this.transform.position, radius);
        }
    }
}
