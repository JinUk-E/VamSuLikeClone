using UnityEngine;
using UnityEngine.UI;

public class ModalView : UIView
{
    [SerializeField] private Image background;
    public override void OnEnter()
    {
        // show modal view
        background.gameObject.SetActive(true);
        Next(name);
    }

    public override void OnExit()
    {
        background.gameObject.SetActive(false);
        Back();
    }
}
