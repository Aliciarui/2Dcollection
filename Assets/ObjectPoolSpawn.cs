using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPoolSpawn : MonoBehaviour
{
    public ObjectPool<myzombie> _pool;
    [SerializeField] private myzombie _myzombiePrefab;

    private void Start()
    {
        _pool = new ObjectPool<myzombie>(
            CreateZombie,
            OnTakeZombieFromPool,
            OnReturnZombieFromPool,
            OnDestroyZombie,
            true,
            5,
            50
        );

        StartCoroutine(SpawnZombieRoutine());
    }

    private myzombie CreateZombie()
    {
        myzombie newZombie = Instantiate(_myzombiePrefab, Vector3.zero, Quaternion.identity);
        newZombie.SetPool(_pool);
        return newZombie;
    }

    private void OnTakeZombieFromPool(myzombie zombie)
    {
        //zombie.transform.position = Vector3.zero;
        zombie.gameObject.SetActive(true);
    }

    private void OnReturnZombieFromPool(myzombie zombie)
    {
        zombie.gameObject.SetActive(false);
    }

    private void OnDestroyZombie(myzombie zombie)
    {
        Destroy(zombie.gameObject);
    }

    public myzombie SpawnZombie()
    {
        return _pool.Get();
    }

    IEnumerator SpawnZombieRoutine()
    {
        while (true)
        {
            SpawnZombie();
            yield return new WaitForSeconds(1f);
        }
    }
}
