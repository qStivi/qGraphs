using Unity.VisualScripting;
using UnityEngine;

public class ConnectNodes : MonoBehaviour
{
    public new Camera camera;

    public long clicks;

    public GameObject object1;

    private void Update()
    {
        var mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetAxis("Fire3") > .5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (object1.IsUnityNull())
                {
                    var c2D = Physics2D.OverlapPoint(mousePos);
                    if (!Physics2D.OverlapPoint(mousePos).IsUnityNull()) object1 = c2D.gameObject;
                }
                else
                {
                    GameObject object2 = null;
                    var c2D = Physics2D.OverlapPoint(mousePos);
                    if (!Physics2D.OverlapPoint(mousePos).IsUnityNull()) object2 = c2D.gameObject;

                    if (!object2.IsUnityNull()) Connect(object1, object2);
                }
            }
        }
        else
        {
            object1 = null;
        }
    }

    public void Connect(GameObject go1, GameObject go2)
    {
        go1.GetComponent<Connection>().gameObjects.Add(go2);
        var sj = go1.AddComponent<SpringJoint2D>();
        sj.connectedBody = go2.GetComponent<Rigidbody2D>();
        sj.distance = 5;
        sj.dampingRatio = 3;
        sj.frequency = 3;
        go1 = null;
    }
}