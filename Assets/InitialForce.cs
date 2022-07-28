using UnityEngine;

public class InitialForce : MonoBehaviour
{
    public float force;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
    }
}