using UnityEngine;

public class LifeModel : MonoBehaviour
{
    private int _life;
    public int Life
    {
        get => _life;
        set
        {
            _life = value;
            if (_life <= 0)
            {
                PoolingSystem.Instance.ReturnObject(gameObject.name, gameObject);
            }
        }
    }
}
