using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
    immovable, flat, up, down
}

public class Block : MonoBehaviour
{
    private bool isInitialized = false;
    private BlockType type;

    public void Initialize(BlockType type)
    {
        if (isInitialized)
            throw new MultipleInitailizeException();

        this.type = type;
        
    }
}
