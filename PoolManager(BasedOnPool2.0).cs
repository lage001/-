using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] GameObject rocketPrefab;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject enemyRocketPrefab;

    public static Dictionary<string, Pool<GameObject>> poolDic;
    private void Awake()
    {
        InitPoolDic();
    }
    void InitPoolDic()
    {
        poolDic = new Dictionary<string, Pool<GameObject>>()
        {
            {PoolConst.RocketPool,new Pool<GameObject>(CreateItem, rocketPrefab)},
            {PoolConst.EnemyRocketPool,new Pool<GameObject>(CreateItem, enemyRocketPrefab)},
            {PoolConst.EnemyPool,new Pool<GameObject>(CreateItem, enemyPrefab)},
        };
    }
    GameObject CreateItem(GameObject prefab)
    {
        GameObject obj = Instantiate(prefab);
        obj.SetActive(true);
        return obj;
    }
}
public class PoolConst
{
    public const string RocketPool = "RocketPool";
    public const string EnemyRocketPool = "EnemyRocketPool";
    public const string EnemyPool = "EnemyPool";
}
