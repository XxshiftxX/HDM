using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject BlockPrefab;

    public Map<Unit> UnitMap = new Map<Unit>(5, 5);
    public Map<Block> BlockMap = new Map<Block>(5, 5);

    public void MoveUnit(Unit unit, Point position)
    {
        Point distance = UnitMap[unit] - position;
    }

    private void CreateBlock(int x, int y, BlockType type)
    {
        BlockMap[x, y] = Instantiate(BlockPrefab, new Vector3(x * 1.6f, -7, y * 1.6f), new Quaternion()).GetComponent<Block>();
        BlockMap[x, y].Initialize(type);
    }
}
