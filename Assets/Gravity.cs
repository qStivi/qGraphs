using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public List<Rigidbody2D> bodies;
    public float gravitationalMultiplier;

    private void Update()
    {
        bodies.RemoveAll(o => o.IsDestroyed());
        foreach (var body in bodies)
        foreach (var otherBody in bodies)
        {
            if (otherBody.Equals(body)) continue;

            var d = Vector2.Distance(body.position, otherBody.position);
            var force = gravitationalMultiplier * (body.mass * otherBody.mass / Mathf.Pow(d, 2));

            var direction = body.transform.position - otherBody.transform.position;

            if (direction != Vector3.zero) body.AddForce(direction * force, ForceMode2D.Force);
        }
    }
}