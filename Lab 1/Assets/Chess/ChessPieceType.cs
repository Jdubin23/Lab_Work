using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;


public class ChessType : MonoBehaviour
{
    public GameObject chessPiece;
    public Color pieceColor = Color.black;

    public int pieceType = 6; // will be used for switch case to determine what chess piece it is.


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 position = transform.position;
    }


    private void FixedUpdate()
    {
        if (Selection.Contains(chessPiece))
        {
            // Draw Lines in here

            switch (pieceType) //will change what type of piece this is.
            {
                case 0:
                    break;
                case 1: //pawn
                    break;
                case 2: //King
                    break;
                case 3: //Queen
                    break;
                case 4: //Rook
                    break;
                case 5: //Knight
                    break;
                case 6: //Bishop
                    break;

            }
        }

    }




}
