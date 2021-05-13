using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private int _damage;

    public void OnButtonClick()
    {
        int value = (int)_healthBar.value - _damage;
        _healthBar.DOValue(value, 0.5f).SetEase(Ease.Linear);
    }
}
