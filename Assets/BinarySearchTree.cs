public class BinarySearchTree
{
    public static Node Insert(Node root, Node z)
    {
        var y = root;
        while (y != null)
        {
            z.p = y;
            y = z.key > y.key ? y.left : y.right;

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

        return root;
    }

    public static Node Min(Node x)
    {
        while (x.left != null) x = x.left;

        return x;
    }

    public static Node Max(Node x)
    {
        while (x.right != null) x = x.right;

        return x;
    }

    public static Node Successor(Node x)
    {
        if (x.right != null) return Min(x.right);

        var y = x.p;
        while (y != null && x == y.right)
        {
            x = y;
            y = x.p;
        }

        return y;
    }

    public static Node Predecessor(Node x)
    {
        if (x.left != null) return Max(x.left);

        var y = x.p;
        while (y != null && x == y.left)
        {
            x = y;
            y = x.p;
        }

        return y;
    }

    public static Node Root(Node x)
    {
        if (x.p == null)
            return x;
        Root(x.p);

        return null;
    }

    public static Node Delete(Node root, Node z)
    {
        Node y;
        if (z.left == null || z.right == null)
            y = z;
        else
            y = Successor(z);

        var x = y.left ?? y.right;

        if (x != null) x.p = y.p;

        if (y.p == null)
            root = x;
        else if (y == y.p.left)
            y.p.left = x;
        else
            y.p.right = x;

        if (y != z) z.key = y.key;

        return root;
    }
}
