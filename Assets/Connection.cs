using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Connection : MonoBehaviour
{
    public List<GameObject> gameObjects;
    private LineRenderer _lr;

    private void Start()
    {
        _lr = GetComponent<LineRenderer>();
        _lr.widthMultiplier = .3f;
        gameObjects.Add(gameObject);
    }

    private void Update()
    {
        gameObjects.RemoveAll(o => o.IsDestroyed());

        _lr.positionCount = (gameObjects.Count - 1) * 2;
        var count = 1;
        for (var i = 0; i < _lr.positionCount; i++)
        {
            var go = gameObjects[count];
            _lr.SetPosition(i, transform.position);
            _lr.SetPosition(++i, go.transform.position);
            count++;
        }
    }
}