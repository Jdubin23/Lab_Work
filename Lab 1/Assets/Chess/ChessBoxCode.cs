using System;
using UnityEngine;

public class ChessBoxCode : MonoBehaviour
{

    public Vector3 size = Vector3.one; // for the size of the cubes
    [Range(0f, 1f)]
    public float alpha = 0.5f;
    public float incriment = 5f; // Increment value for position change
    public int SquaresPerRow = 8; // Number of squares per row
    private int y = 0; // Counter for the number of squares drawn
    private void OnDrawGizmos()
    {
        // Set the color with custom alpha.


        for (int x = 0; x < SquaresPerRow; x++)
        {
            for (int z = 0; z < SquaresPerRow; z++)
            {
                if (0 == y % 2)
                {
                    Gizmos.color = new Color(0, 0, 0, alpha); // Black with custom alpha
                }
                else
                {
                    Gizmos.color = new Color(1, 1, 1, alpha); // White with custom alpha
                }
                // Calculate the position for each square.
                Vector3 position = transform.position + new Vector3(x * incriment, 0, z * incriment);
                // Draw the cube at the calculated position.
                Gizmos.DrawCube(position, size);
                y++;
            }
            y++;
        }
        // Draw the cube.
        //Gizmos.DrawCube(transform.position, size);

        // Draw a wire cube outline.
        //Gizmos.color = Color.white;
        //Gizmos.DrawWireCube(transform.position, size);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
