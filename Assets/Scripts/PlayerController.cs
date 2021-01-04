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

    /// <summary>
    /// Gets the player input then sends it to the player's character
    /// </summary>
    private void GetPlayerInput()
    {

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