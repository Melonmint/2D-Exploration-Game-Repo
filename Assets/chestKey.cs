using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestKey : MonoBehaviour
{
    public Transform mover;
    public Vector3 messagePosition;
    public Vector3 goBack;
    public Camera mainCamera;
    public bool key = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (key == false)
        {
            mover.position = messagePosition;
        }
        if (key == true)
        {
            mainCamera.depth = -3;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        mover.position = goBack;
    }
}
