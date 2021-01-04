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

    void Update()
    {
        GetPlayerInput();
    }

    /// <summary>
    /// Gets the player input then sends it to the player's character
    /// </summary>
    private void GetPlayerInput()
    {
        float[] temp = new float[3];

        temp[0] = Input.GetAxis("Horizontal");
        temp[1] = Input.GetAxis("Vertical");

        Debug.Log(temp[0]);

        if (Input.GetButton("Sprint"))
        {
            temp[2] = 1f;
        } else
        {
            temp[2] = 0f;
        }

        PlayerControlledCharacter.Move(temp);

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