using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    private float animationLength = 2f;
    private float timer = 0;
    [SerializeField] private Timing.EasingType easing;
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > animationLength)
            timer = 0;
        var step = timer / animationLength;
        slider.value = Timing.Ease(step, easing);
    }
}
