﻿using UnityEngine;
using UnityEngine.UI;

public class AnimationLerpNumber : MonoBehaviour
{
    private float animationLength = 5f;
    private float timer = 0;
    private Timing timing;
    [SerializeField] private Timing.EasingType easing;
    private Text text;

    private void Start()
    {
        timing = new Timing();
        text = GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > animationLength)
            timer = 0;
        var step = timer / animationLength;
        text.text = timing.LerpInt(step, easing, 0, 50).ToString();
    }
}
