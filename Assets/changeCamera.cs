using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamera : MonoBehaviour
{
    public Camera mainCamera;
    CircleCollider2D circleCollider;
    private void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }
    void Start()
    {
        circleCollider.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        mainCamera.depth = -3;
    }
    // Start is called before the first frame update


    // Update is called once per frame
}
