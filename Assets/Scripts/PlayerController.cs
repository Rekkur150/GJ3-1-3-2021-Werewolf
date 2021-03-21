using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("The character that the player will control")]
    public Character PlayerControlledCharacter;

    [Tooltip("The player score contorller")]
    public Score PlayerScore;

    [Tooltip("The player hud")]
    public Hud PlayerHud;

    [Tooltip("The player vision controler")]
    public Vision PlayerVision;

    [Tooltip("The player's camera")]
    public Camera PlayerCamera;

    void Update()
    {
        GetPlayerInput();
    }

    /// <summary>
    /// Gets the player input then sends it to the player's character
    /// </summary>
    private void GetPlayerInput()
    {

        ///Movement Controls
        float[] temp = new float[3];

        temp[0] = Input.GetAxis("Horizontal");
        temp[1] = Input.GetAxis("Vertical");

        if (Input.GetButton("Sprint"))
        {
            temp[2] = 1f;
        } else
        {
            temp[2] = 0f;
        }

        PlayerControlledCharacter.Move(temp);


        ///Character Rotation
        Vector3 mousePosition = PlayerCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        if (Input.GetMouseButtonDown(0))
        {

            
            MapController.instance.GetTileData(new Vector3Int(Mathf.FloorToInt(mousePosition.x), Mathf.FloorToInt(mousePosition.y), 0)).Destroyed();
        }

        PlayerControlledCharacter.LookAt(mousePosition);
    }

    /// <summary>
    /// Updates the hud with the correct information
    /// </summary>
    private void UpdateHud()
    {

    }

    /// <summary>
    /// Updates the player vision area
    /// </summary>
    private void UpdateVision()
    {

    }
}