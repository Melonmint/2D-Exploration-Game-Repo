using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangeSprite : MonoBehaviour
{
    public float color1;
    public float color2;
    public float color3;
    public bool change = false;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("HELLO");
        if (collision.gameObject.CompareTag("splatter"))
        {
            spriteRenderer.color = collision.gameObject.GetComponent<SpriteRenderer>().color;
        }
        

    }
    private void Update()
    {
        spriteRenderer.color = new Color(color1, color2, color3, 1.0f);
    }

    // Update is called once per frame
}
