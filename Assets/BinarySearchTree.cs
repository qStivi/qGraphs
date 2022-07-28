using UnityEngine;

public class BinarySearchTree : MonoBehaviour
{
    public Node root;

    public void BinaryInsert(Node z)
    {
        var y = root;
        while (y != null)
        {
            z.p = y;
            if (z.key > y.key)
                y = y.left;
            else
                y = y.right;

            if (z.p == null)
            {
                root = z;
            }
            else
            {
                if (z.key < z.p.key)
                    z.p.left = z;
                else
                    z.p.right = z;
            }
        }
    }
}