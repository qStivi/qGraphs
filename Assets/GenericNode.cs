using System;
using System.Collections.Generic;
using UnityEngine;

public class GenericNode : MonoBehaviour
{
    public List<GenericNode> adjacencyList;

    public void Connect(GenericNode node)
    {
        adjacencyList.Add(node);
        RenderConnections();
    }

    private void RenderConnections()
    {
        var lr = GetComponent<LineRenderer>();
        // lr.
        for (var i = 0; i < adjacencyList.Count; i++) throw new NotImplementedException();
    }
}
