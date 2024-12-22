using UnityEngine;
using UnityEngine.Pool;

public class myzombie : MonoBehaviour
{
    private ObjectPool<myzombie> pool;

    public void SetPool(ObjectPool<myzombie> pool)
    {
        this.pool = pool;
    }

    private void OnEnable()
    {
        Invoke(nameof(ReturnToPool), 10f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void ReturnToPool()
    {
        pool.Release(this);
    }
}
