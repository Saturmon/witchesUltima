using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField]
    public string _name;
    [SerializeField]
    public float _life;
    [SerializeField]
    public float _maxLife;
    [SerializeField]
    public float _damageBase;
    [SerializeField]
    public float _armor;
    [SerializeField]
    public float _additionalDamage;
    [SerializeField]
    public float _vampirism;
    [SerializeField]
    public float _shieldbreaker;


    public float Attack()
    {
        float attack = (_damageBase) - (_armor - _shieldbreaker);
        return attack;
    }
    public float LifeStealing()
    {
        float LifeStealing = 8 + (Attack() * (_vampirism / 100));
        return LifeStealing;
    }
    public void RecibirDaño()
    {
        _life = _life - Attack();
    }
    public void RecibirDaño(float _additionalDamage)
    {
        _life = _life - _additionalDamage;
    }
    public void Curarse()
    {
        float roboDeVida = LifeStealing();
        if (_life < _maxLife)
        {
            _life = _life + roboDeVida;
            if (_life > _maxLife)
            {
                _maxLife = _life;
            }
        }
    }
    /*public void EfectoPocima(Pocimadecuración pocion)
    {
        float curacion = pocion.Effect();
        if (_life < _maxLife)
        {
            _life = _life + curacion;
            if (_life > _maxLife)
            {
                _maxLife = _life;
            }
        }
    }*/
}