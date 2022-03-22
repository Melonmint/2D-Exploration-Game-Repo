using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class level2timer : MonoBehaviour
{
    public TMP_Text myText;
    public Transform mover;
    public Vector3 returnPosition;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        float t = 0.0f;
        while (t < 90.0f)
        {
            t += Time.deltaTime;
            int b = (int)t;
            int c = 90 - b;
            myText.text = "Time Left: " + c.ToString() + " Seconds"; 
            yield return null;
        }
        mover.position = returnPosition;
        myText.text = "Too Slow! Try again";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
