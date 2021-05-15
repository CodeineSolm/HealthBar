using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{   
    [SerializeField] private int _health;

    private int _maxHealth;

    public event UnityAction<int> HealthChanged;
    public int MaxHealth => _maxHealth;

    public void ApplyDamage(int damage)
    {
        if (_health <= 0)
        {
            //Die
        }
        else
        {
            _health -= damage;
        }

        HealthChanged?.Invoke(_health);
    }

    public void ApplyHeal(int healAmount)
    {
        if (_health >= _maxHealth)
        {
            _health = _maxHealth;
        }
        else
        {
            _health += healAmount;
        }

        HealthChanged?.Invoke(_health);
    }

    private void Start()
    {
        _maxHealth = _health;
        HealthChanged?.Invoke(_health);
    }
}
