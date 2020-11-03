using System.Collections.Generic;
using UnityEngine;

public class Timing
{
    public enum EasingType
    {
        EaseInSin, EaseOutSin, easeInOutSine, easeInQuad, easeOutQuad, easeInOutQuad, easeInCubic, easeOutCubic, easeInOutCubic, easeInQuart, easeOutQuart, easeInOutQuart, easeInQuint, easeOutQuint, easeInOutQuint, easeInExpo, easeOutExpo, easeInOutExpo, easeInCirc, easeOutCirc, easeInOutCirc, easeInBack, easeOutBack, easeInOutBack, easeInElastic, easeOutElastic, easeInOutElastic, easeInBounce, easeOutBounce, easeInOutBounce
    }
    private float EaseInSin(float x)
    {
        return 1f - Mathf.Cos((x * Mathf.PI) * 0.5f);
    }
    private float EaseOutSin(float x)
    {
        return Mathf.Sin((x * Mathf.PI) * 0.5f);
    }
    private float easeInOutSine(float x)
    {
        return -(Mathf.Cos(Mathf.PI * x) - 1f) * 0.5f;
    }
    private float easeInQuad(float x)
    {
        return x * x;
    }
    private float easeOutQuad(float x)
    {
        return 1f - (1f - x) * (1f - x);
    }
    private float easeInOutQuad(float x)
    {
        return x < 0.5f ? 2f * x * x : 1f - Mathf.Pow(-2f * x + 2f, 2f) * 0.5f;
    }
    private float easeInCubic(float x)
    {
        return x * x * x;
    }
    private float easeOutCubic(float x)
    {
        return 1f - Mathf.Pow(1f - x, 3f);
    }
    private float easeInOutCubic(float x)
    {
        return x < 0.5f ? 4f * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 3f) * 0.5f;
    }
    private float easeInQuart(float x)
    {
        return x * x * x * x;
    }
    private float easeOutQuart(float x)
    {
        return 1f - Mathf.Pow(1f - x, 4f);
    }
    private float easeInOutQuart(float x)
    {
        return x < 0.5f ? 8f * x * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 4f) * 0.5f;
    }
    private float easeInQuint(float x)
    {
        return x * x * x * x * x;
    }
    private float easeOutQuint(float x)
    {
        return 1f - Mathf.Pow(1f - x, 5f);
    }
    private float easeInOutQuint(float x)
    {
        return x < 0.5f ? 16f * x * x * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 5f) * 0.5f;
    }
    private float easeInExpo(float x)
    {
        return x == 0f ? 0f : Mathf.Pow(2f, 10f * x - 10f);
    }
    private float easeOutExpo(float x)
    {
        return x == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * x);
    }
    private float easeInOutExpo(float x)
    {
        if (x == 0f)
            return 0f;
        else if (x == 1f)
            return 1f;
        else if (x < 0.5f)
            return Mathf.Pow(2f, 20f * x - 10f) * 0.5f;
        else
            return (2f - Mathf.Pow(2f, -20f * x + 10f)) * 0.5f;
    }
    private float easeInCirc(float x)
    {
        return 1f - Mathf.Sqrt(1f - Mathf.Pow(x, 2f));
    }
    private float easeOutCirc(float x)
    {
        return Mathf.Sqrt(1f - Mathf.Pow(x - 1f, 2f));
    }
    private float easeInOutCirc(float x)
    {
        if (x < 0.5f)
            return (1f - Mathf.Sqrt(1f - Mathf.Pow(2f * x, 2f))) * 0.5f;
        else
            return (Mathf.Sqrt(1f - Mathf.Pow(-2f * x + 2f, 2f)) + 1f) * 0.5f;
    }
    private float easeInBack(float x)
    {
        var c1 = 1.70158f;
        var c3 = c1 + 1f;

        return c3 * x * x * x - c1 * x * x;
    }
    private float easeOutBack(float x)
    {
        var c1 = 1.70158f;
        var c3 = c1 + 1f;

        return 1f + c3 * Mathf.Pow(x - 1f, 3f) + c1 * Mathf.Pow(x - 1f, 2f);
    }
    private float easeInOutBack(float x)
    {
        var c1 = 1.70158f;
        var c2 = c1 * 1.525f;

        if (x < 0.5f)
            return (Mathf.Pow(2f * x, 2f) * ((c2 + 1f) * 2f * x - c2)) * 0.5f;
        else
            return (Mathf.Pow(2f * x - 2f, 2f) * ((c2 + 1f) * (x * 2f - 2f) + c2) + 2f) * 0.5f;
    }
    private float easeInElastic(float x)
    {
        var c4 = (2f * Mathf.PI) * 0.33333333333333333f;

        if (x == 0f)
            return 0f;
        else if (x == 1f)
            return 1f;
        else
            return -Mathf.Pow(2f, 10f * x - 10f) * Mathf.Sin((x * 10f - 10.75f) * c4);
    }
    private float easeOutElastic(float x)
    {
        var c4 = (2f * Mathf.PI) * 0.33333333333333333f;

        if (x == 0f)
            return 0f;
        else if (x == 1f)
            return 1f;
        else
            return Mathf.Pow(2f, -10f * x) * Mathf.Sin((x * 10f - 0.75f) * c4) + 1f;
    }
    private float easeInOutElastic(float x)
    {
        var c5 = (2f * Mathf.PI) / 4.5f;

        if (x == 0f)
            return 0f;
        else if (x == 1f)
            return 1f;
        if (x < 0.5f)
            return -(Mathf.Pow(2f, 20f * x - 10f) * Mathf.Sin((20f * x - 11.125f) * c5)) * 0.5f;
        else
            return (Mathf.Pow(2f, -20f * x + 10f) * Mathf.Sin((20f * x - 11.125f) * c5)) * 0.5f + 1f;
    }
    private float easeInBounce(float x)
    {
        return 1f - easeOutBounce(1f - x);
    }
    private float easeOutBounce(float x)
    {
        var n1 = 7.5625f;
        var d1 = 2.75f;

        if (x < 1f / d1)
        {
            return n1 * x * x;
        }
        else if (x < 2f / d1)
        {
            return n1 * (x -= 1.5f / d1) * x + 0.75f;
        }
        else if (x < 2.5f / d1)
        {
            return n1 * (x -= 2.25f / d1) * x + 0.9375f;
        }
        else
        {
            return n1 * (x -= 2.625f / d1) * x + 0.984375f;
        }
    }
    private float easeInOutBounce(float x)
    {
        if (x < 0.5f)
            return (1f - easeOutBounce(1f - 2f * x)) * 0.5f;
        else
            return (1f + easeOutBounce(2f * x - 1f)) * 0.5f;
    }
    public float Ease(float time, EasingType easing)
    {
        switch (easing)
        {
            case EasingType.EaseInSin:
                return EaseInSin(time);
            case EasingType.EaseOutSin:
                return EaseOutSin(time);
            case EasingType.easeInOutSine:
                return easeInOutSine(time);
            case EasingType.easeInQuad:
                return easeInQuad(time);
            case EasingType.easeOutQuad:
                return easeOutQuad(time);
            case EasingType.easeInOutQuad:
                return easeInOutQuad(time);
            case EasingType.easeInCubic:
                return easeInCubic(time);
            case EasingType.easeOutCubic:
                return easeOutCubic(time);
            case EasingType.easeInOutCubic:
                return easeInOutCubic(time);
            case EasingType.easeInQuart:
                return easeInQuart(time);
            case EasingType.easeOutQuart:
                return easeOutQuart(time);
            case EasingType.easeInOutQuart:
                return easeInOutQuart(time);
            case EasingType.easeInQuint:
                return easeInQuint(time);
            case EasingType.easeOutQuint:
                return easeOutQuint(time);
            case EasingType.easeInOutQuint:
                return easeInOutQuint(time);
            case EasingType.easeInExpo:
                return easeInExpo(time);
            case EasingType.easeOutExpo:
                return easeOutExpo(time);
            case EasingType.easeInOutExpo:
                return easeInOutExpo(time);
            case EasingType.easeInCirc:
                return easeInCirc(time);
            case EasingType.easeOutCirc:
                return easeOutCirc(time);
            case EasingType.easeInOutCirc:
                return easeInOutCirc(time);
            case EasingType.easeInBack:
                return easeInBack(time);
            case EasingType.easeOutBack:
                return easeOutBack(time);
            case EasingType.easeInOutBack:
                return easeInOutBack(time);
            case EasingType.easeInElastic:
                return easeInElastic(time);
            case EasingType.easeOutElastic:
                return easeOutElastic(time);
            case EasingType.easeInOutElastic:
                return easeInOutElastic(time);
            case EasingType.easeInBounce:
                return easeInBounce(time);
            case EasingType.easeOutBounce:
                return easeOutBounce(time);
            case EasingType.easeInOutBounce:
                return easeInOutBounce(time);
            default:
                return 0;
        }
    }
}