using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayRiddles : MonoBehaviour
{
    CircleCollider2D circleCollider;
    public Transform mover;
    public Vector3 messagePosition;
    public Vector3 goBack;
    public Transform mover2;
    public Vector3 colliderPosition;
    // Start is called before the first frame update
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
        mover.position = messagePosition;
        mover2.position = colliderPosition;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        mover.position = goBack;
    }
}
