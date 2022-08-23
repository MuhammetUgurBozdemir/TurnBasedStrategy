using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem
{
    private int width, height;
    private float cellSize;
    public GridSystem(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        for (int i = 0; i < width; i++)
        {
            for (int z = 0; z < height; z++)
            {
                Debug.DrawLine(GetWorldPositipon(i, z), GetWorldPositipon(i, z) + Vector3.right * .2f, Color.white, 1000);
            }
        }
    }
    public Vector3 GetWorldPositipon(int x, int z)
    {
        return new Vector3(x, 0, z) * cellSize;
    }

    public GridPosition GetGridPosition(Vector3 worldPosition)
    {
        return new GridPosition
            (
                Mathf.RoundToInt(worldPosition.x/cellSize),
                Mathf.RoundToInt(worldPosition.z/cellSize)
            );
    }
}
