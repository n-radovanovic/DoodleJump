using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent (typeof(Rigidbody2D))]
public class dudler : MonoBehaviour
{
    float brzinaKretanja = 10f;

    float kretanje = 0;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        kretanje = Input.GetAxis("Horizontal") * brzinaKretanja;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = kretanje;
        rb.velocity = velocity;
    }
}
