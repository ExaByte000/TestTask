using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public AudioClip HitSound;
    private AudioSource HitSoundSource => GetComponent<AudioSource>();
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            rb.AddForce(cursorPosition * speed * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HitSoundSource.PlayOneShot(HitSound);
    }
}
