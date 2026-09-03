using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ChessType))]
public class EditorFile : Editor
{
    public ChessType ChessPiecebytyp;
    private readonly string[] pieceNames = { "King", "Queen", "Bishop", "Knight", "Rook", "Pawn" };

     public override void OnInspectorGUI(){

        DrawDefaultInspector();
        ChessType piece = (ChessType)target;

        for (int i = 0; i < pieceNames.Length; i++)
        {
            if (GUILayout.Button(pieceNames[i]))
            {
                piece.pieceType = i;
                piece.spriteRenderer.sprite = piece.Sprites[piece.pieceType];
            }
        }

    }
}
