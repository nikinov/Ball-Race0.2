using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPooler : MonoBehaviour
{
    public int poolSize;
    public GameObject road;

    Queue<GameObject> pool;

    private void Awake()
    {
        pool = new Queue<GameObject>();

        for (int s = 0; s < poolSize; s++)
        {
            GameObject instObj = Instantiate(road);
            instObj.SetActive(false);
            pool.Enqueue(instObj);
        }
    }

    public void SpawnFromPool(Vector3 pos, Quaternion rotation)
    {
        GameObject obj = pool.Dequeue();
        obj.transform.position = pos;
        obj.transform.rotation = rotation;
        obj.SetActive(true);
        pool.Enqueue(obj);

    }

}
