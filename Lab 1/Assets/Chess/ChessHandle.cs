using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using Unity.Hierarchy;

// calculates chess piece moves
public class ChessHandle : MonoBehaviour
{
    

    public void DrawKingMove()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(4, 1, 4);
        //Vector3 position = transform.position;
        
        Gizmos.DrawCube(transform.position + transform.forward * 5, size);
        Gizmos.DrawCube(transform.position + transform.right * 5, size);
        Gizmos.DrawCube(transform.position + transform.forward * -5, size);
        Gizmos.DrawCube(transform.position + transform.right * -5, size);
        Gizmos.DrawCube(transform.position + transform.forward * 5 + transform.right * 5, size);
        Gizmos.DrawCube(transform.position + transform.forward * 5 + transform.right * -5, size);
        Gizmos.DrawCube(transform.position + transform.forward * -5 + transform.right * 5, size);
        Gizmos.DrawCube(transform.position + transform.forward * -5 + transform.right * -5, size);
    }

    public void DrawPawnMove()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(4, 1, 4);
        Gizmos.DrawCube(transform.position + transform.forward * 5, size);
    }

    public void DrawQueenMove()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(4, 1, 4);
        int moves = 8;
        Vector3 position = transform.position;

        for (int i = 0; i <= moves; i++) //up
        {
            Gizmos.DrawCube(position + new Vector3(0, 0, 5), size);
            position = position + new Vector3(0, 0, 5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //right
        {
            Gizmos.DrawCube(position + new Vector3(5, 0, 0), size);
            position = position + new Vector3(5, 0, 0);
        }
        position = transform.position;
        for (int i = 0; i <= moves; i++) //left
        {
            Gizmos.DrawCube(position + new Vector3(-5, 0, 0), size);
            position = position + new Vector3(-5, 0, 0);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //down
        {
            Gizmos.DrawCube(position + new Vector3(0, 0, -5), size);
            position = position + new Vector3(0, 0, -5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //up + right
        {
            Gizmos.DrawCube(position + new Vector3(5, 0, 5), size);
            position = position + new Vector3(5, 0, 5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //left + up
        {
            Gizmos.DrawCube(position + new Vector3(-5, 0, 5), size);
            position = position + new Vector3(-5, 0, 5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) // down + left
        {
            Gizmos.DrawCube(position + new Vector3(-5, 0, -5), size);
            position = position + new Vector3(-5, 0, -5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) // right + down
        {
            Gizmos.DrawCube(position + new Vector3(5, 0, -5), size);
            position = position + new Vector3(5, 0, -5);
        }
        position = transform.position;
    }

    public void DrawRookMove()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(4, 1, 4);
        int moves = 8;
        Vector3 position = transform.position;

        for (int i = 0; i <= moves; i++) // Up
        {
            Gizmos.DrawCube(position + new Vector3(0, 0, 5), size);
            position = position + new Vector3(0, 0, 5);
        }
        position = transform.position; // Right
        for(int i = 0; i <= moves; i++)
        {
            Gizmos.DrawCube(position + new Vector3(5, 0, 0), size);
            position = position + new Vector3(5, 0, 0);
        }
        position = transform.position;
        for (int i = 0; i <= moves; i++) //left
        {
            Gizmos.DrawCube(position + new Vector3(-5, 0, 0), size);
            position = position + new Vector3(-5, 0, 0);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //down
        {
            Gizmos.DrawCube(position + new Vector3(0, 0, -5), size);
            position = position + new Vector3(0, 0, -5);
        }
        position = transform.position;
    }

    public void DrawBishopMove()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(4, 1, 4);
        int moves = 8;
        Vector3 position = transform.position;

        for(int i = 0; i <= moves; i++) //up + right
        {
            Gizmos.DrawCube(position + new Vector3(5, 0, 5), size);
            position = position + new Vector3(5, 0, 5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //left + up
        {
            Gizmos.DrawCube(position + new Vector3(-5, 0, 5), size);
            position = position + new Vector3(-5, 0, 5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) // down + left
        {
            Gizmos.DrawCube(position + new Vector3(-5, 0, -5), size);
            position = position + new Vector3(-5, 0, -5);
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) // right + down
        {
            Gizmos.DrawCube(position + new Vector3(5, 0, -5), size);
            position = position + new Vector3(5, 0, -5);
        }
        position = transform.position;
    }

    public void DrawKnightMove()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(4, 1, 4);
        int moves = 1;
        int knightMoves = 1;
        Vector3 position = transform.position;
        
        for (int i = 0; i <= moves; i++) // Up
        {
            // Gizmos.DrawCube(position + new Vector3(0, 0, 5), size); //draws the cube
            position = position + new Vector3(0, 0, 5); //sets position

            if (i == moves)
            {
                Gizmos.DrawCube(position + new Vector3(5, 0, 0), size);
                Gizmos.DrawCube(position + new Vector3(-5, 0, 0), size);
            }
        }
        position = transform.position; // Right
        for(int i = 0; i <= moves; i++)
        {
            // Gizmos.DrawCube(position + new Vector3(5, 0, 0), size);
            position = position + new Vector3(5, 0, 0);

            if (i == moves)
            {
                Gizmos.DrawCube(position + new Vector3(0, 0, 5), size);
                Gizmos.DrawCube(position + new Vector3(0, 0, -5), size);
            }
        }
        position = transform.position;
        for (int i = 0; i <= moves; i++) //left
        {
            //Gizmos.DrawCube(position + new Vector3(-5, 0, 0), size);
            position = position + new Vector3(-5, 0, 0);

            if (i == moves)
            {
                Gizmos.DrawCube(position + new Vector3(0, 0, 5), size);
                Gizmos.DrawCube(position + new Vector3(0, 0, -5), size);
            }
        }
        position = transform.position;
        for(int i = 0; i <= moves; i++) //down
        {
            //Gizmos.DrawCube(position + new Vector3(0, 0, -5), size);
            position = position + new Vector3(0, 0, -5);

            if (i == moves)
            {
                Gizmos.DrawCube(position + new Vector3(5, 0, 0), size);
                Gizmos.DrawCube(position + new Vector3(-5, 0, 0), size);
            }
        }
        position = transform.position;
    }




}
