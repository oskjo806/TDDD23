using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap wallTilemap;
    private PlayerMovement controls;
    private Camera cam = null;

    private void Awake()
    {
        controls = new PlayerMovement();
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        controls.Main.Movement.performed += OnMove;
        controls.Main.LeftMouseClick.performed += _ => LeftClick();
        controls.Main.RightMouseClick.performed += _ => RightClick();
    }
    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        if (CanMove(direction))
        {
            transform.position += (Vector3)direction;
        }
    }
    
    private void OnMoveLongFloor(Vector3Int endPosition)
    {
        //TODO Calculate which moves needs to be made and make them
        while(floorTilemap.WorldToCell(transform.position) != endPosition)
        {
            Vector3Int playerPos = floorTilemap.WorldToCell(transform.position);
            int deltaX = playerPos.x - endPosition.x;
            int deltaY = playerPos.y - endPosition.y;
            if(Mathf.Abs(deltaX) > Mathf.Abs(deltaY))
            {
                if (deltaX < 0 && CanMove(Vector2.right))
                {
                    transform.position += Vector3.right;
                }
                else if (deltaX > 0 && CanMove(Vector2.left))
                {
                    transform.position += Vector3.left;
                }
                else if (deltaY < 0 && CanMove(Vector2.up))
                {
                    transform.position += Vector3.up;
                }
                else if (deltaY > 0 && CanMove(Vector2.down))
                {
                    transform.position += Vector3.down;
                }
                else
                    break;
            }
            else
            {
                if (deltaY < 0 && CanMove(Vector2.up))
                {
                    transform.position += Vector3.up;
                }
                else if (deltaY > 0 && CanMove(Vector2.down))
                {
                    transform.position += Vector3.down;
                }
                else if (deltaX < 0 && CanMove(Vector2.right))
                {
                    transform.position += Vector3.right;
                }
                else if (deltaX > 0 && CanMove(Vector2.left))
                {
                    transform.position += Vector3.left;
                }
                else
                    break;
            }
            
        }
    }

    private void RightClick()
    {
        //TODO
        Debug.Log("rightclick");
    }

    private void LeftClick()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Vector2 worldPosition = cam.ScreenToWorldPoint(mousePosition);
        Vector3Int gridPosition = floorTilemap.WorldToCell(worldPosition);
        if (gridPosition == floorTilemap.WorldToCell(transform.position))
        {
            //TODO
            Debug.Log("Player");
        }
        else if (floorTilemap.HasTile(gridPosition))
        {
            //TODO: MAKE VALID MOVES UNTIL PLAYER AT TILE
            Debug.Log("floor");
            OnMoveLongFloor(gridPosition);
        }
        else if (wallTilemap.HasTile(gridPosition))
        {
            Debug.Log("wall");
        }

    }

    private bool CanMove(Vector2 direction)
    {
        Vector3Int gridPosition = floorTilemap.WorldToCell(transform.position + (Vector3)direction);
        if (!floorTilemap.HasTile(gridPosition) || wallTilemap.HasTile(gridPosition))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
