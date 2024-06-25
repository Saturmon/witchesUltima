using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : Personaje
{
    private void Awake()
    {
    }

    private void Start()
    {
        _name = "Asesino sin sueldo";
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

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            SceneManager.LoadScene("");
        }
    }
}
