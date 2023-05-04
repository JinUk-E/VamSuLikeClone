using RNBUtil;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class MapSettingPresenter : MonoBehaviour
{
    [SerializeField] private GameObject area;
    private void Start()
    {
        DebugerEx.Logger("Start Trigger Rx",DebugerEx.DebugType.Log);
        // use Trigger for Trigger Exit Event Move to Area
        this.OnTriggerExit2DAsObservable()
            .Where(other => other.CompareTag("Area"))
            .Subscribe(_ => MoveToArea())
            .AddTo(this);
        
    }

    private void MoveToArea()
    {
        DebugerEx.Logger("MoveToArea",DebugerEx.DebugType.Log);
        // Move to Area
        transform.position = area.transform.position;
    }
}
