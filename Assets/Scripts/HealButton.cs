using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private int _restoreHealthAmount;

    public void OnButtonClick()
    {
        int value = (int)_healthBar.value + _restoreHealthAmount;
        _healthBar.DOValue(value, 0.5f).SetEase(Ease.Linear);
    }
}
