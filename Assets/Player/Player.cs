using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{

    public bool isDead { get; private set; }

    public int Health { get; private set; }
    public int Mana { get; private set; }
    public int Energy { get; private set; }
    public int Defense { get; private set; }
    public int Resistance { get; private set; }
    public int Speed { get; private set; }
    public int AttackSpeed{ get; private set; }
    public int Attack{ get; private set; }
    public int Power{ get; private set; }


    PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = new PlayerMovement();
    }

    public Player()
    {

    }

    public void TakeDamage(DamageType _damageType, int amount)
    {
        int takenDamage = 0;
        switch(_damageType)
        {
            case DamageType.Physical:
                takenDamage = amount - Defense;
                break;
            case DamageType.Magical:
                takenDamage = amount - Resistance;
                break;
            case DamageType.Piercing:
                takenDamage = amount;
                break;
        }

        Health -= takenDamage;
        if(Health <= 0)
        {
            isDead = true;
        }
    }
}
