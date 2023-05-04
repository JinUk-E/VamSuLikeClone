using RNBUtil;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class MapSettingPresenter : MonoBehaviour
{
    [SerializeField] private CompositeCollider2D tilemap;
    [SerializeField] private GameObject area;
    private void Start()
    {
        DebugerEx.Logger("Start Trigger Rx",DebugerEx.DebugType.Log);
        tilemap.OnTriggerExitAsObservable().
            Where(col => col.CompareTag("Area")).
            Subscribe(_ => gameObject.transform.position = area.transform.position).AddTo(this);
    }
}
