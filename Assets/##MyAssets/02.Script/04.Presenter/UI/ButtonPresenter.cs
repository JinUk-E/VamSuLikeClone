using UniRx;
using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonPresenter : MonoBehaviour
{
    // This is a base class for all UI presenters.
    // Maybe MainMenuPresenter, GameOverPresenter, etc. will be derived from this class.
    
    [SerializeField] private Button button;

    private void Start()
    {
        button.OnClickAsObservable().Subscribe(_=> OnClick()).AddTo(this);
    }
    
    protected abstract void OnClick();
}
