using System.Collections.Generic;
using UnityEngine;

public class Timing
{
    public enum EasingType
    {
        EaseInSin, EaseOutSin, EaseInOutSine, EaseInQuad, EaseOutQuad, EaseInOutQuad, EaseInCubic, EaseOutCubic, EaseInOutCubic, EaseInQuart, EaseOutQuart, EaseInOutQuart, EaseInQuint, EaseOutQuint, EaseInOutQuint, EaseInExpo, EaseOutExpo, EaseInOutExpo, EaseInCirc, EaseOutCirc, EaseInOutCirc, EaseInBack, EaseOutBack, EaseInOutBack, EaseInElastic, EaseOutElastic, EaseInOutElastic, EaseInBounce, EaseOutBounce, EaseInOutBounce
    }
    private float EaseInSin(float x)
    {
        return 1f - Mathf.Cos((x * Mathf.PI) * 0.5f);
    }
    private float EaseOutSin(float x)
    {
        return Mathf.Sin((x * Mathf.PI) * 0.5f);
    }
    private float EaseInOutSine(float x)
    {
        return -(Mathf.Cos(Mathf.PI * x) - 1f) * 0.5f;
    }
    private float EaseInQuad(float x)
    {
        return x * x;
    }
    private float EaseOutQuad(float x)
    {
        return 1f - (1f - x) * (1f - x);
    }
    private float EaseInOutQuad(float x)
    {
        return x < 0.5f ? 2f * x * x : 1f - Mathf.Pow(-2f * x + 2f, 2f) * 0.5f;
    }
    private float EaseInCubic(float x)
    {
        return x * x * x;
    }
    private float EaseOutCubic(float x)
    {
        return 1f - Mathf.Pow(1f - x, 3f);
    }
    private float EaseInOutCubic(float x)
    {
        return x < 0.5f ? 4f * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 3f) * 0.5f;
    }
    private float EaseInQuart(float x)
    {
        return x * x * x * x;
    }
    private float EaseOutQuart(float x)
    {
        return 1f - Mathf.Pow(1f - x, 4f);
    }
    private float EaseInOutQuart(float x)
    {
        return x < 0.5f ? 8f * x * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 4f) * 0.5f;
    }
    private float EaseInQuint(float x)
    {
        return x * x * x * x * x;
    }
    private float EaseOutQuint(float x)
    {
        return 1f - Mathf.Pow(1f - x, 5f);
    }
    private float EaseInOutQuint(float x)
    {
        return x < 0.5f ? 16f * x * x * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 5f) * 0.5f;
    }
    private float EaseInExpo(float x)
    {
        return x == 0f ? 0f : Mathf.Pow(2f, 10f * x - 10f);
    }
    private float EaseOutExpo(float x)
    {
        return x == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * x);
    }
    private float EaseInOutExpo(float x)
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
    private float EaseInCirc(float x)
    {
        return 1f - Mathf.Sqrt(1f - Mathf.Pow(x, 2f));
    }
    private float EaseOutCirc(float x)
    {
        return Mathf.Sqrt(1f - Mathf.Pow(x - 1f, 2f));
    }
    private float EaseInOutCirc(float x)
    {
        if (x < 0.5f)
            return (1f - Mathf.Sqrt(1f - Mathf.Pow(2f * x, 2f))) * 0.5f;
        else
            return (Mathf.Sqrt(1f - Mathf.Pow(-2f * x + 2f, 2f)) + 1f) * 0.5f;
    }
    private float EaseInBack(float x)
    {
        var c1 = 1.70158f;
        var c3 = c1 + 1f;

        return c3 * x * x * x - c1 * x * x;
    }
    private float EaseOutBack(float x)
    {
        var c1 = 1.70158f;
        var c3 = c1 + 1f;

        return 1f + c3 * Mathf.Pow(x - 1f, 3f) + c1 * Mathf.Pow(x - 1f, 2f);
    }
    private float EaseInOutBack(float x)
    {
        var c1 = 1.70158f;
        var c2 = c1 * 1.525f;

        if (x < 0.5f)
            return (Mathf.Pow(2f * x, 2f) * ((c2 + 1f) * 2f * x - c2)) * 0.5f;
        else
            return (Mathf.Pow(2f * x - 2f, 2f) * ((c2 + 1f) * (x * 2f - 2f) + c2) + 2f) * 0.5f;
    }
    private float EaseInElastic(float x)
    {
        var c4 = (2f * Mathf.PI) * 0.33333333333333333f;

        if (x == 0f)
            return 0f;
        else if (x == 1f)
            return 1f;
        else
            return -Mathf.Pow(2f, 10f * x - 10f) * Mathf.Sin((x * 10f - 10.75f) * c4);
    }
    private float EaseOutElastic(float x)
    {
        var c4 = (2f * Mathf.PI) * 0.33333333333333333f;

        if (x == 0f)
            return 0f;
        else if (x == 1f)
            return 1f;
        else
            return Mathf.Pow(2f, -10f * x) * Mathf.Sin((x * 10f - 0.75f) * c4) + 1f;
    }
    private float EaseInOutElastic(float x)
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
    private float EaseInBounce(float x)
    {
        return 1f - EaseOutBounce(1f - x);
    }
    private float EaseOutBounce(float x)
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
    private float EaseInOutBounce(float x)
    {
        if (x < 0.5f)
            return (1f - EaseOutBounce(1f - 2f * x)) * 0.5f;
        else
            return (1f + EaseOutBounce(2f * x - 1f)) * 0.5f;
    }
    public float Ease(float time, EasingType easing)
    {
        switch (easing)
        {
            case EasingType.EaseInSin:
                return EaseInSin(time);
            case EasingType.EaseOutSin:
                return EaseOutSin(time);
            case EasingType.EaseInOutSine:
                return EaseInOutSine(time);
            case EasingType.EaseInQuad:
                return EaseInQuad(time);
            case EasingType.EaseOutQuad:
                return EaseOutQuad(time);
            case EasingType.EaseInOutQuad:
                return EaseInOutQuad(time);
            case EasingType.EaseInCubic:
                return EaseInCubic(time);
            case EasingType.EaseOutCubic:
                return EaseOutCubic(time);
            case EasingType.EaseInOutCubic:
                return EaseInOutCubic(time);
            case EasingType.EaseInQuart:
                return EaseInQuart(time);
            case EasingType.EaseOutQuart:
                return EaseOutQuart(time);
            case EasingType.EaseInOutQuart:
                return EaseInOutQuart(time);
            case EasingType.EaseInQuint:
                return EaseInQuint(time);
            case EasingType.EaseOutQuint:
                return EaseOutQuint(time);
            case EasingType.EaseInOutQuint:
                return EaseInOutQuint(time);
            case EasingType.EaseInExpo:
                return EaseInExpo(time);
            case EasingType.EaseOutExpo:
                return EaseOutExpo(time);
            case EasingType.EaseInOutExpo:
                return EaseInOutExpo(time);
            case EasingType.EaseInCirc:
                return EaseInCirc(time);
            case EasingType.EaseOutCirc:
                return EaseOutCirc(time);
            case EasingType.EaseInOutCirc:
                return EaseInOutCirc(time);
            case EasingType.EaseInBack:
                return EaseInBack(time);
            case EasingType.EaseOutBack:
                return EaseOutBack(time);
            case EasingType.EaseInOutBack:
                return EaseInOutBack(time);
            case EasingType.EaseInElastic:
                return EaseInElastic(time);
            case EasingType.EaseOutElastic:
                return EaseOutElastic(time);
            case EasingType.EaseInOutElastic:
                return EaseInOutElastic(time);
            case EasingType.EaseInBounce:
                return EaseInBounce(time);
            case EasingType.EaseOutBounce:
                return EaseOutBounce(time);
            case EasingType.EaseInOutBounce:
                return EaseInOutBounce(time);
            default:
                return 0;
        }
    }

    public float Lerp(float step, EasingType easing, float from, float to)
    {
        var val = Ease(step, easing);
        return Mathf.Lerp(from, to, val);
    }
    public int LerpInt(float step, EasingType easing, int from, int to)
    {
        var val = Ease(step, easing);
        return Mathf.RoundToInt(Mathf.Lerp(from, to, val));
    }

    public Vector2 Lerp(float step, EasingType easing, Vector2 from, Vector2 to)
    {
        var val = Ease(step, easing);
        return Vector2.Lerp(from, to, val);
    }

    public Vector3 Lerp(float step, EasingType easing, Vector3 from, Vector3 to)
    {
        var val = Ease(step, easing);
        return Vector3.Lerp(from, to, val);
    }

    public Vector4 Lerp(float step, EasingType easing, Vector4 from, Vector4 to)
    {
        var val = Ease(step, easing);
        return Vector4.Lerp(from, to, val);
    }

    public Quaternion Lerp(float step, EasingType easing, Quaternion from, Quaternion to)
    {
        var val = Ease(step, easing);
        return Quaternion.Lerp(from, to, val);
    }

    public Color Lerp(float step, EasingType easing, Color from, Color to)
    {
        var val = Ease(step, easing);
        return Color.Lerp(from, to, val);
    }

    public Color32 Lerp(float step, EasingType easing, Color32 from, Color32 to)
    {
        var val = Ease(step, easing);
        return Color32.Lerp(from, to, val);
    }
}