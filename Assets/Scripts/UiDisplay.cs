using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UiDisplay : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text scoreText;
    
    [SerializeField] private Health health;
    private ScoreKeeper _scoreKeeper;
    private void Awake()
    {
        _scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void Start()
    {
        slider.maxValue = health.GetHealth();
    }

    void Update()
    {
        scoreText.text = _scoreKeeper.GetCurrentScore().ToString("000000000");
        slider.value = health.GetHealth();
    }
}
