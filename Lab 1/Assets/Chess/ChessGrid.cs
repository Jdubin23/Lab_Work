using System;
using UnityEngine;

public class ChessGrid : MonoBehaviour
{
    
    // private int x = 8; // Counter for the number of squares drawn
    // private int z = 8; // Counter for the number of squares drawn
    public int SquaresPerRow = 8; // Number of squares per row
    public Vector3 verticalSize = Vector3.one; // for the size of the cubes
    public Vector3 horizontalSize = Vector3.one; // for the size of the cubes
    public float incriment = 5;
    [Range(0f, 1f)]
    public float alpha = 0.5f;
    [Header("Horizontal Lines")]
    public float w = 5; // Increment value for position change
    public float m = 5;
    [Header("Vertical Lines")]
    public float UpInc = 5f; // Increment value for position change
    public float LeftInc = 5f; // Increment value for position change


    private void OnDrawGizmos()
    {
        DrawChessGrid();
    }

   
    private void DrawChessGrid()
    {
        // Vertical Lines
        for (int x = 0; x < SquaresPerRow; x++)
        {
            for (int z = 0; z < SquaresPerRow; z++)
            {
                    Gizmos.color = new Color(1, 1, 1, alpha);
                // Calculate the position for each square.
                Vector3 position = transform.position + new Vector3(x * incriment - LeftInc, 0, z - UpInc);
                // Draw the cube at the calculated position.
                Gizmos.DrawCube(position, verticalSize);
                
            }
        }
        // Vertical Lines
        for (int x = 0; x < SquaresPerRow; x++)
        {
            for (int z = 0; z < SquaresPerRow; z++)
            {
                    Gizmos.color = new Color(1, 1, 1, alpha);
                // Calculate the position for each square.
                Vector3 position = transform.position + new Vector3(x - m, 0, z * incriment - w);
                // Draw the cube at the calculated position.
                Gizmos.DrawCube(position, horizontalSize);
                
            }
        }
    }
}
