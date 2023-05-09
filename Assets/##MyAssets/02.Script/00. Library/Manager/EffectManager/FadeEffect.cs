using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : UIEffector
{
    [SerializeField] private float duration = 5f;
    [SerializeField] private Image transitionImage;
    [SerializeField] private AnimationCurve curve;
    private bool _istransitionImageNotNull;
    private void Start() => _istransitionImageNotNull = transitionImage != null;

    protected override void Effect(bool isEffect)
    {
        transitionImage.gameObject.SetActive(true);
        StartCoroutine(Fade(isEffect));
    }

    private IEnumerator Fade(bool isEffect)
    {
        var time = duration;
        yield return null;
        while (time > 0f || time < duration)
        {
            time -= (isEffect ? 1 : -1) * Time.deltaTime;
            var alpha = curve.Evaluate(time / duration);

            if (_istransitionImageNotNull)
            {
                var bgColor = transitionImage.color;
                transitionImage.color = new Color(bgColor.a,bgColor.g, bgColor.b, alpha);
            }
            yield return null;
        }
        transitionImage.gameObject.SetActive(false);
    }
}
