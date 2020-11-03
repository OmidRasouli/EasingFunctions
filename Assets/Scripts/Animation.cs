using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    private float animationLength = 2f;
    private float timer = 0;
    private Timing timing;
    [SerializeField] private Timing.EasingType easing;
    private Slider slider;

    private void Start()
    {
        timing = new Timing();
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > animationLength)
            timer = 0;
        var step = timer / animationLength;
        slider.value = timing.Ease(step, easing);
    }
}
