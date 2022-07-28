using UnityEngine;

public class AddNode : MonoBehaviour
{
    public GameObject prefab;

    public void InsertNode()
    {
        // Request value from user
        // Create new node with value
        // Insert created node into tree
        // build binary tree with values

        // var value = 
    }

    public void BuildBinaryTree(Node root)
    {
        if (root == null) return;
        var bodies = GetComponent<Gravity>().bodies;
        var position = Vector3.zero;
        if (bodies.Count == 0) position = new Vector3(0, 7, 0);
        var rb = Instantiate(prefab, position, new Quaternion(), transform).GetComponent<Rigidbody2D>();
        bodies.Add(rb);
        if (bodies.Count == 0) rb.constraints = RigidbodyConstraints2D.FreezePosition;
        if (root.p != null)
        {
            // GetComponent<ConnectNodes>().Connect(root.p.gameObject, root.gameObject);
        }

        BuildBinaryTree(root.left);
        BuildBinaryTree(root.right);
    }
}