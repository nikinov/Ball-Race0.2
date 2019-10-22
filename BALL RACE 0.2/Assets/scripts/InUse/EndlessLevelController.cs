using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessLevelController : MonoBehaviour
{
    public Transform player;
    public float chunkSize;
    public RoadPooler pooler;

    private Vector3 lastPlatformPos;
    private Vector3 FirstRoadBounds;

    private void Start()
    {
        lastPlatformPos = transform.position;
        FirstRoadBounds = transform.position;
        Generate();
        FirstRoadBounds.z += chunkSize;
    }

    void Update()
    {
        chekForPlayerPos();
    }

    private void chekForPlayerPos()
    {
        if(player.position.z > FirstRoadBounds.z)
        {
            placeRoad();
            FirstRoadBounds.z += chunkSize;
        }
    }

    private void Generate()
    {
        for(int r = 0; r < pooler.poolSize; r++)
        {
            placeRoad();
        }
    }

    private void placeRoad()
    {
        pooler.SpawnFromPool(lastPlatformPos, Quaternion.Euler(-90,0,0));
        lastPlatformPos.z += chunkSize;
    }
}
