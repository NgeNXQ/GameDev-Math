using UnityEngine;
using UnityEngine.UIElements;

public sealed class TransformingSpaceCoordinates : MonoBehaviour
{
    [SerializeField]
    private GameObject mainGameObject;

    [SerializeField]
    private GameObject examinedGameObject;

    private static void TransformToLocalSpace(GameObject main, GameObject examined)
    {
        Debug.Log($"{nameof(main)} has coordinates {main.transform.position} in global space.");
        Debug.Log($"{nameof(examined)} has coordinates {examined.transform.position} in global space.");

        Vector2 mainPositionInLocal = new Vector2(0, 0);
        Vector2 examinedPositionInLocal = examined.transform.position - main.transform.position;

        Debug.Log($"{nameof(main)} has coordinates {mainPositionInLocal} in local space.");
        Debug.Log($"{nameof(examined)} has coordinates {examinedPositionInLocal} in local space.");
    }

    private static void TransformToGlobalSpace(Vector2 mainPosition, Vector2 examinedPosition)
    {
        //Debug.Log($"{nameof(main)} has coordinates {mainPositionInLocal} in local space.");
        //Debug.Log($"{nameof(examined)} has coordinates {examinedPositionInLocal} in local space.");        
    }

    private void Start()
    {
        
    }
}
