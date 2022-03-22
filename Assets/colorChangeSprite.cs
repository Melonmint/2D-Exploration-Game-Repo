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
            StartCoroutine(ColorChange(spriteRenderer.color, collision.gameObject.GetComponent<SpriteRenderer>().color));
            //spriteRenderer.color = collision.gameObject.GetComponent<SpriteRenderer>().color;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopAllCoroutines();
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

    IEnumerator ColorChange(Color c1, Color c2)
    {
        spriteRenderer.color = c1;
        float t = 0.0f;
        while (t < 1.0f)
        {
            spriteRenderer.color = Color.Lerp(c1, c2, t);
            t += Time.deltaTime * 0.5f;
            yield return null;
        }
        spriteRenderer.color = c2;
    }
}
