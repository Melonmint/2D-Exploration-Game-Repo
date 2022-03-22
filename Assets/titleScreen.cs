using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleScreen : MonoBehaviour
{
    public Camera titleCamera;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            titleCamera.depth = -3;
        }
    }
    // Start is called before the first frame update


    // Update is called once per frame
}

