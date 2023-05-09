using System.Collections;
using UnityEngine;

public class SlideEffect : UIEffector
{
    [SerializeField] private RectTransform from;
    [SerializeField] private RectTransform to;
    [SerializeField] private float duration = 1.0f;
    protected override void Effect(bool isEffect)   
    {
        StartCoroutine(Slide(isEffect));
    }

    private IEnumerator Slide(bool isEffect)
    {
        var time = 0f;
        while (time < duration)
        {
            time += Time.deltaTime;
            var lerp = time / duration;
            var startPos = isEffect ? Vector2.zero : new Vector2(Screen.width,0);
            var endPos = isEffect ? new Vector2(Screen.width,0) : Vector2.zero;
            from.anchoredPosition = Vector2.Lerp(-startPos, -endPos, lerp);
            to.anchoredPosition = Vector2.Lerp(startPos, endPos, lerp);
            yield return null;
        }
    }
}
