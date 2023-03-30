/*
 * Lucas Johnson
 * PlayerController
 * Assignment 9
 * Controls the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region///////////// Public Variables: ///////////////

    // References
    [Header("Refrences:")]
    [Tooltip("Reference to the transform of the first person camera")]
    [SerializeField] Transform playerCamera = null;


    // Movement
    [Header("Movement:")]
    [Tooltip("Controls the speed at which the player looks around with the mouse")]
    [SerializeField] public float mouseSensitivity = 3.5f;
    [Tooltip("The speed at which the player moves")]
    [SerializeField] float walkSpeed = 6f;
    [Tooltip("The speed at which the player moves towards the ground")]
    [SerializeField] float gravity = -13f;
    [Tooltip("The amount of smoothing when the player starts and stops moving")]
    [SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;
    [Tooltip("The amount of smoothing when the player starts and stops looking around with the mouse")]
    [SerializeField] [Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;
    #endregion

    #region///////////// Private Variables: ///////////////

    // Refrences
    private CharacterController controller;

    // Movement
    float cameraPitch = 0f;
    float velocityY = 0f;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;
    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;
    #endregion

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // Call Movement updates
        UpdateMouseLook();
        UpdateMovement();

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }    
    }

    /// <summary>
    /// Handles looking around using the mouse position
    /// </summary>
    void UpdateMouseLook()
    {
        // Get Mouse Input, smooth, and adjust it to match chosen sensitivity
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);
        cameraPitch -= currentMouseDelta.y * mouseSensitivity;

        // Restrict camera from moving past straight up & down
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);

        // Update camera and player rotation based on input
        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * currentMouseDelta.x * mouseSensitivity);
    }

    /// <summary>
    /// Handles moving the player around using the WASD keys
    /// </summary>
    void UpdateMovement()
    {
        // Get Movement input and smooth it
        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);

        // Handle if the player is falling
        if (controller.isGrounded)
        {
            velocityY = 0f;
        }
        velocityY += gravity * Time.deltaTime;

        // Calculate velocity based on set movement speed and apply it to the player
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed + Vector3.up * velocityY;
        controller.Move(velocity * Time.deltaTime);
    }
}
