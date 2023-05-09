using UnityEngine;

public abstract class UIEffector : MonoBehaviour
{
    // set effect for UI Change
    public void EffectStart(bool isEffect) => Effect(isEffect);
    protected abstract void Effect(bool isEffect);
}
