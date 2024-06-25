using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonista : Personaje
{
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    public int velocityx;
    public int velocityy;
    public void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void Start()
    {
        _life = 190;
        _maxLife = 190;
        _damageBase = 70;
        _armor = 32;
        _additionalDamage = 0;
        _vampirism = 0;
        _shieldbreaker = 0;
    }
    private void Update()
    {
        if (Input.GetKey("s"))
        {
            _animator.SetBool("IsWalkingDown", true);
        }
        else if (Input.GetKey("s") == false)
        {
            _animator.SetBool("IsWalkingDown", false);
        }
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            _animator.SetBool("IsWalkingHacia los lados", true);

        }
        else
        {
            _animator.SetBool("IsWalkingHacia los lados", false);
        }

        if (Input.GetKey("d"))
        {
            _spriteRenderer.flipX = true;
        }
        else if (Input.GetKey("d") == false)
        {
            _spriteRenderer.flipX = false;
        }
        if (Input.GetKey("w"))
        {
            _animator.SetBool("IsWalkingHaciaArriba", true);
        }
        else if (Input.GetKey("w") == false)
        {
            _animator.SetBool("IsWalkingHaciaArriba", false);
        }

    }
    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x + velocityx * Time.deltaTime, _rigidbody2D.position.y);
        }

        if (Input.GetKey("a"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x - velocityx * Time.deltaTime, _rigidbody2D.position.y);
        }
        if (Input.GetKey("w"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x, _rigidbody2D.position.y + velocityy * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x, _rigidbody2D.position.y - velocityy * Time.deltaTime);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
