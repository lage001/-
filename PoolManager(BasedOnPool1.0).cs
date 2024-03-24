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
            {PoolConst.RocketPool,new Pool<GameObject>(CreateRocket)},
            {PoolConst.EnemyRocketPool,new Pool<GameObject>(CreateEnemyRocket)},
            {PoolConst.EnemyPool,new Pool<GameObject>(CreateEnemy)},
        };
    }
    GameObject CreateRocket()
    {
        GameObject obj = Instantiate(rocketPrefab);
        obj.SetActive(true);
        return obj;
    }
    GameObject CreateEnemyRocket()
    {
        GameObject obj = Instantiate(enemyRocketPrefab);
        obj.SetActive(true);
        return obj;
    }
    GameObject CreateEnemy()
    {
        GameObject obj = Instantiate(enemyPrefab);
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
