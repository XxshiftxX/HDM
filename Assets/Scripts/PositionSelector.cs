using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSelector : MonoBehaviour {

    public int number;

    private void OnMouseDown()
    {
        Debug.Log(number);
    }

    public void Initialize()
    {

    }

}
