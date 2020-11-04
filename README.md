# Easing functions for Unity
 ### Easing functions included:
  1.  EaseInSin
  2.  EaseOutSin
  3.  easeInOutSine
  4.  easeInQuad
  5.  easeOutQuad
  6.  easeInOutQuad
  7.  easeInCubic
  8.  easeOutCubic
  9.  easeInOutCubic
  10. easeInQuart
  11. easeOutQuart
  12. easeInOutQuart
  13. easeInQuint
  14. easeOutQuint
  15. easeInOutQuint
  16. easeInExpo
  17. easeOutExpo
  18. easeInOutExpo
  19. easeInCirc
  20. easeOutCirc
  21. easeInOutCirc
  22. easeInBack
  23. easeOutBack
  24. easeInOutBack
  25. easeInElastic
  26. easeOutElastic
  27. easeInOutElastic
  28. easeInBounce
  29. easeOutBounce
  30. easeInOutBounce

I used [Easing function cheat sheet](https://easings.net) equtions to develop this project.

------------------------------------------------

Just create a `new Timing()` to use `Ease(step, EasingType)`.
For using `Ease()`, the first parameter is `step` between 0 - 1, the second parameter is the type of easing.

**For example:**
```
  var timing = new Timing();
  var value = timing.Ease(0.2f, EasingType.EaseInSin);
```

------------------------------------------------

For interpolation between two {numbers, points, colors, quaternions} use `Lerp()` instead of using `Ease()`. `Lerp()` function has two more parameters. The third parameter is `from`, The fourth parameter is `to`.

**For example:**
```
  var timing = new Timing();
  var value = timing.Ease(0.2f, EasingType.EaseInSin, from, to);
```

------------------------------------------------

#### This project has 2 scenes to show how it works
