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

    [SerializeField]
    private float moveSpeed = 5f;
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
        //controls.Main.Movement.performed += OnMove;
        controls.Main.LeftMouseClick.performed += _ => LeftClick();
        controls.Main.RightMouseClick.performed += _ => RightClick();
    }

    void Update(){
        Vector2 direction = controls.Main.Movement.ReadValue<Vector2>();
        transform.position += (Vector3)direction*moveSpeed*Time.deltaTime;
    }

    private void RightClick()
    {
        // låt stå ifall vi vill använda till nått annat
        Debug.Log("rightclick");
    }

    private void LeftClick()
    {
        // låt stå ifall vi vill använda till nått annat
        Debug.Log("leftclick");

    }
    // void Update(){
    //     if(IndexOutOfRangeException.GetKey(KeyCode.RightArrow)){
    //         buttonPressed = RIGHT;
    //     }
    // }

    // private void FixedUpdate(){
    //     if(button pressed){
    //         hastighet = vec2 (movespeed,0)
    //     }
    //     else(button pressed left)
    // }
}


