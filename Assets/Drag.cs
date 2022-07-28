using UnityEngine;
using UnityEngine.Serialization;

public class Drag : MonoBehaviour
{
    public GameObject selectedObject;

    [FormerlySerializedAs("cam")] public new Camera camera;

    private Collider2D targetObject;

    private void Update()
    {
        var mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) targetObject = Physics2D.OverlapPoint(mousePos);
        if (Input.GetAxis("Fire1") > .5)
            if (targetObject)
            {
                if (selectedObject == null) selectedObject = targetObject.transform.gameObject;

                selectedObject.GetComponent<Rigidbody2D>().position = mousePos;
            }

        if (Input.GetAxis("Fire1") < .5 && selectedObject) selectedObject = null;
    }
}