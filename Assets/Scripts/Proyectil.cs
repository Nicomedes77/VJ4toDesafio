using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public Vector3 dir;
    public float speed = 20f;
    public int damage;
    
    void Update()
    {
        transform.position += dir * speed;
    }
}
