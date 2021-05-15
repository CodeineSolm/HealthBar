using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _restoreHealthAmount;

    public void OnButtonClick()
    {
        _player.ApplyHeal(_restoreHealthAmount);
    }
}
