using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private void Start()
    {
        new GridSystem(10, 10 , 2f);
        Debug.Log(new GridPosition(5, 7));
    }
}
