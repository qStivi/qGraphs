using Unity.VisualScripting;
using UnityEngine;

public class RemoveNode : MonoBehaviour
{
    public new Camera camera;

    private void Update()
    {
        var mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(1))
        {
            var targetObject = Physics2D.OverlapPoint(mousePos);
            GameObject go = null;
            if (targetObject) go = targetObject.gameObject;
            if (!go.IsUnityNull()) Destroy(go);
        }
    }
}