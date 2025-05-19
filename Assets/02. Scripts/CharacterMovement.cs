using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public SoundManager soundManager;
    
    public SpriteRenderer[] renderers;
    private Rigidbody2D characterRb;

    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    private float h;

    public bool isGround;

    void Start()
    {
        renderers = this.GetComponentsInChildren<SpriteRenderer>(true);
        characterRb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround) // isGround == true
            {
                soundManager.OnJumpSound();
                characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            }
        }
    }

    void FixedUpdate()
    {
        if (h != 0)
        {
            renderers[0].gameObject.SetActive(false);
            renderers[1].gameObject.SetActive(true);
            characterRb.linearVelocityX = h * moveSpeed;

            if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
            }
            else if (h < 0)
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
            }
        }
        else
        {
            renderers[0].gameObject.SetActive(true);
            renderers[1].gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isGround = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isGround = false;
    }
}