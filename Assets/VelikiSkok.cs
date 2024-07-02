using UnityEngine;

public class VelikiSkok : MonoBehaviour
{
    public float JumpForce = 20f;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                //velocity zbir svih sila. uzimamo vektor, modifikujemo jedan deo, vracamo 
                Vector2 velocity = rb.velocity;

                velocity.y = JumpForce;

                rb.velocity = velocity;

            }
        }


    }
}
