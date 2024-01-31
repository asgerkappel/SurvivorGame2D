using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public int damage = 5;
    public float WalkSpeed;
    public float JumpForce;
    public AnimationClip _walk, _jump;
    public Animation _Legs;
    public Transform _Blade, _GroundCast;
    public Camera cam;
    public bool mirror;
    public int maxHP = 100;
    public int currentHP;

    // Metode til at tage skade
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player died.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Enemy"){
            TakeDamage(damage);
        }
    }

    private bool _canJump, _canWalk;
    private bool _isWalk, _isJump;
    private float rot, _startScale;
    private Rigidbody2D rig;
    private Vector2 _inputAxis;
    private RaycastHit2D _hit;



    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>(); // Henter Rigidbody2D-komponenten fra spilleren
        _startScale = transform.localScale.x; // Gemmer spillerens startskala
        currentHP = maxHP;  // Sætter spillerens HP til at være lig med maxHP ved start.
    }

    void Update()
    {
        if (_hit = Physics2D.Linecast(new Vector2(_GroundCast.position.x, _GroundCast.position.y + 0.2f), _GroundCast.position))
        {
            if (!_hit.transform.CompareTag("Player"))
            {
                _canJump = true;
                _canWalk = true;
            }
        }
        else _canJump = false;

        _inputAxis = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (_inputAxis.y > 0 && _canJump)
        {
            _canWalk = false;
            _isJump = true;
        }
    }

    void FixedUpdate()
{
    // Input fra tastaturet
    float horizontalInput = Input.GetAxisRaw("Horizontal");

    // Retningen, som spilleren bevæger sig mod
    Vector2 moveDirection = new Vector2(horizontalInput, 0);

    // Normaliser retningen for at undgå bevægelse med forskellige hastigheder diagonalt
    moveDirection.Normalize();

    // Bevægelse baseret på tastaturinput (A og D)
    rig.velocity = new Vector2(moveDirection.x * WalkSpeed * Time.deltaTime, rig.velocity.y);

    // Spejlvendt scaling og rotation baseret på bevægelsesretning
    if (horizontalInput > 0)
    {
        mirror = false;
        transform.localScale = new Vector3(_startScale, _startScale, 1);
    }
    else if (horizontalInput < 0)
    {
        mirror = true;
        transform.localScale = new Vector3(-_startScale, _startScale, 1);
    }

    // Afspilning af gang-animation, hvis spilleren bevæger sig
    if (horizontalInput != 0 && _canWalk)
    {
        _Legs.clip = _walk;
        _Legs.Play();
    }

    // Hoplogik
    if (_inputAxis.y > 0 && _canJump)
    {
        _canWalk = false;
        _isJump = true;
    }

    // Jump handling (kan tilpasses efter behov)
    if (_isJump)
    {
        rig.AddForce(new Vector2(0, JumpForce));
        _Legs.clip = _jump;
        _Legs.Play();
        _canJump = false;
        _isJump = false;
    }
}


    public bool IsMirror()
    {
        return mirror;
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, _GroundCast.position);
    }
}
