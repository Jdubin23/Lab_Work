using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;


public class ChessType : MonoBehaviour
{
    public GameObject chessPiece;
    public Color pieceColor = Color.black;
    public Sprite[] Sprites = new Sprite[6];
    public SpriteRenderer spriteRenderer;
    public Transform endPoint;

    [Header("Directions")]
    [HideInInspector] public Vector3 N = new Vector3(0, 1, 0).normalized;
    [HideInInspector] public Vector3 NE = new Vector3(1, 1, 0).normalized;
    [HideInInspector] public Vector3 E = new Vector3(1, 0, 0).normalized;
    [HideInInspector] public Vector3 SE = new Vector3(1, -1, 0).normalized;
    [HideInInspector] public Vector3 S = new Vector3(0, -1, 0).normalized;
    [HideInInspector] public Vector3 SW = new Vector3(-1, -1, 0).normalized;
    [HideInInspector] public Vector3 W = new Vector3(-1, 0, 0).normalized;
    [HideInInspector] public Vector3 NW = new Vector3(-1, 1, 0).normalized;

    public int pieceType = 6; // will be used for switch case to determine what chess piece it is.
    public float stepDistance = 1f; // Distance to move in each direction

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 position = transform.position;
    }

    void OnValidate()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();

        }

        spriteRenderer.color = pieceColor;
    }

    private void FixedUpdate()
    {
        
    }
    private void OnDrawGizmosSelected()
    {

    if (Selection.Contains(gameObject))
        {
            // Draw Lines in here

            switch (pieceType) //will change what type of piece this is.
            {
                case 0: //King
                    DrawDirectionArrow(N);  DrawDirectionArrow(NE);
                     DrawDirectionArrow(SE);
                    DrawDirectionArrow(E); DrawDirectionArrow(W); 
                    DrawDirectionArrow(S);  DrawDirectionArrow(SW);
                     DrawDirectionArrow(NW);
                    break;
                case 1: //Queen
                    DrawDirectionArrow(N);  DrawDirectionArrow(NE);
                    DrawDirectionArrow(E);
                    break;
                case 2: //Bishop
                    break;
                case 3: //Knight
                    break;
                case 4: //Rook
                    break;
                case 5: //Pawn
                    break;


            }
        }

    }

    private void DrawDirectionArrow(Vector3 directionOffset)
    {
        Vector3 start = transform.position;
        Vector3 target = start + (directionOffset.normalized * stepDistance);

        // Draw line connecting start to target
        Gizmos.DrawLine(start, target);

        #if UNITY_EDITOR
        // Draw an arrowhead pointing toward target using Editor Handles
        Handles.color = pieceColor;
        Vector3 dir = (target - start).normalized;
        if (dir != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(dir, Vector3.forward);
            Handles.ArrowHandleCap(0, target, rotation, 0.3f, EventType.Repaint);
        }
        #endif
    }



}
