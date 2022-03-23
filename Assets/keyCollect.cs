using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class keyCollect : MonoBehaviour
{
    public TMP_Text myText;
    public chestKey key;
    public AudioSource audio;
    public AudioClip clip;
    // Start is called before the first frame update
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        float t = 0.0f;
        while (t < 1.0f)
        {
            t += Time.deltaTime;
            yield return null;
        }
        audio.PlayOneShot(clip);
        myText.text = "Key Collected";
        key.key = true;
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
