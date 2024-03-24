using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
public class PoolManager : MonoBehaviour
{
    public GameObject prefab;
    public ObjectPool<GameObject> pool;
    
    private void Start()
    {
        pool = new ObjectPool<GameObject>(createFunc, actionOnGet, actionOnRelease, actionOnDestroy, true, 10, 1000);
        StartCoroutine("Spawn");
    }

    GameObject createFunc()
    {
        var obj = Instantiate(prefab, transform.position,Quaternion.identity);
        return obj;
    }
    public void actionOnGet(GameObject obj)
    {
        obj.SetActive(true);
    }
    void actionOnRelease(GameObject obj)
    {
        obj.SetActive(false);
    }
    void actionOnDestroy(GameObject obj)
    {
        Destroy(obj);
    }
    
}
