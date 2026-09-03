using UnityEngine;

public class FlatGrid : MonoBehaviour
{
    public int width;
    public int height;
    public float cellSize = 1f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;

        // Draw lines across the x axis 
        for (int x = 0; x <= width; x++)
        {
            Vector3 start = transform.position + new Vector3(x * cellSize, 0, 0);
            Vector3 end = start + new Vector3(0, 0, height * cellSize);
            Gizmos.DrawLine(start, end);
        }
        // Draw lines across the z axis
        for (int z = 0; z <= height; z++)
        {
            Vector3 start = transform.position + new Vector3(0, 0, z * cellSize);
            Vector3 end = start + new Vector3(width * cellSize, 0, 0);
            Gizmos.DrawLine(start, end);
        }
    }
}
