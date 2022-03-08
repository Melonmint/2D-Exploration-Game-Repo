using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangeSprite : MonoBehaviour
{
    public float color1;
    public float color2;
    public float color3;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("splatter"))
        {
            spriteRenderer.color = collision.gameObject.GetComponent<SpriteRenderer>().color;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            if (spriteRenderer.color == collision.gameObject.GetComponent<SpriteRenderer>().color)
            {
                Destroy(collision.gameObject);
                //collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    private void Update()
    {
    }
}
