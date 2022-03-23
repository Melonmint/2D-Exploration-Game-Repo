using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;
    public string level2;
    CircleCollider2D circleCollider;
    // Start is called before the first frame update
    private void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        audio = GetComponent<AudioSource>();
    }
    void Start()
    {
        circleCollider.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.PlayOneShot(clip);
        SceneManager.LoadScene(level2);
    }
}
