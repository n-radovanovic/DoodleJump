using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

[RequireComponent (typeof(Rigidbody2D))]
public class dudler : MonoBehaviour
{
    float brzinaKretanja = 10f;

    float kretanje = 0;

    public Text scoreText;

    private float topScore = 0.0f;

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

        if(kretanje < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(kretanje > 0) 
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        



        if(rb.velocity.y > 0 && transform.position.y > topScore)
            topScore = transform.position.y;

        scoreText.text = "Score: " + MathF.Round(topScore).ToString();
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = kretanje;
        rb.velocity = velocity;
    }
}
