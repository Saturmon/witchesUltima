using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : Personaje
{
    public GameObject GameObject;
    private void Awake()
    {

    }

    private void Start()
    {
        _name = "El espiritu";
        _life = 160;
    }

    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jugador"))
        {
            if (Input.GetKey("e"))
            {
                GameObject.SetActive(true);
            }
        }
        
    }
}
