using UnityEngine;

public sealed class GlobalToLocal : MonoBehaviour
{
    [SerializeField]
    private bool scope;

    [SerializeField]
    private GameObject dot;
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;    
        Gizmos.DrawLine(this.transform.position, this.transform.right + this.transform.position);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(this.transform.position, this.transform.up + this.transform.position);

        Gizmos.color = Color.white;
        Gizmos.DrawSphere(this.transform.position, 0.03f);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(dot.transform.position, 0.05f);

        if (scope)
            GlobalScopeToLocalScope();
        else
            LocalScopeToGlobalScope();

        Debug.ClearDeveloperConsole();
    }

    private void GlobalScopeToLocalScope()
    {
        Vector2 dotLocalPosition = new Vector2(dot.transform.position.x - this.transform.position.x,
                                               dot.transform.position.y - this.transform.position.y);

        Debug.Log(dotLocalPosition);
    }

    private void LocalScopeToGlobalScope()
    {
        Vector2 dotLocalPosition = new Vector2(dot.transform.position.x - this.transform.position.x,
                                               dot.transform.position.y - this.transform.position.y);

        Vector2 dotGlobalPosition = (Vector2)this.transform.position + dotLocalPosition;

        Debug.Log(dotGlobalPosition);
    }
}
