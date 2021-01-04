using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    [Tooltip("NPC will try to keep around this position")]
    public Vector2 DefaultLocation;

    [Tooltip("The NPC the distance around it's current location the NPC will just naturally wander")]
    public float WanderDistance;

    [Tooltip("How often a NPC will go larger distances and explore (0,1)")]
    public float ExplorePercentage;

    [Tooltip("The location that a npc will go to that supercedes the default location")]
    public Vector2 ExploreLocation;

    [Tooltip("How often the npc will return to the default location")]
    public float ResetPercentage;

    [Tooltip("How often the npc will move around a location")]
    public float WanderPercentage;

    [Tooltip("Controls Vision")]
    public Vision NPCVision;

    /// <summary>
    /// Goes to the new location
    /// </summary>
    /// <param name="newLocation">NewLocation</param>
    public void GoToLocation(Vector2 newLocation)
    {

    }

    /// <summary>
    /// Returns if the NPC can get to the position or not
    /// </summary>
    /// <param name="location">Location to check</param>
    /// <returns>True if the npc can get there, false if it cannot</returns>
    public bool CanGetToLocation(Vector2 location)
    {
        return new bool();
    }

    /// <summary>
    /// Checks to see if it should change its wander position
    /// </summary>
    /// <returns>Returns true if it should, otherwise false</returns>
    private bool ShouldChangeWanderPosition()
    {
        return new bool();
    }
    
    /// <summary>
    /// Checks to see if it should explore
    /// </summary>
    /// <returns>Return true if it should explore, false otherwise</returns>
    private bool ShouldExplore()
    {
        return new bool();
    }

    /// <summary>
    /// Checks to see if it should return to default position
    /// </summary>
    /// <returns>True if yes, false otherwise</returns>
    private bool ShouldReturnToDefault()
    {
        return new bool();
    }

    /// <summary>
    /// Checks to see if it can see an enemy in vision
    /// </summary>
    /// <returns>Return true if it can see it, return false otherwise.</returns>
    private bool CheckForEnemy()
    {
        return new bool();
    }
}
