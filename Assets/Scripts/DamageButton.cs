using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _damage;

    public void OnButtonClick()
    {
        _player.ApplyDamage(_damage);
    }
}
