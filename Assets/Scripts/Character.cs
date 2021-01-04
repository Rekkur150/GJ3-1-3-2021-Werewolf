using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    /// <summary>
    /// The goal of this class is to keep track of data for characters
    /// </summary>

    [Tooltip("The maxium health for this character")]
    public float MaxHealth;

    [Tooltip("The normal speed for a character")]
    public float WalkingSpeed;

    [Tooltip("The sprinting speed for a character")]
    public float SprintingSpeed;

    [Tooltip("The rotation speed for a character")]
    public float RotationSpeed;

    [Tooltip("The max stamina, controls sprinting time, swing speed")]
    public float MaxStamina;

    [Tooltip("The skills this character has")]
    public Skills skillList;

    [Tooltip("The score value of this character")]
    public float Score;

    private float Health;
    private float Stamina;


    /// <summary>
    /// Gets the health
    /// </summary>
    /// <returns>The health of the entity</returns>
    public float GetHealth()
    {
        return new float();
    }

    /// <summary>
    /// Sets the health of a entity
    /// </summary>
    /// <param name="newHealth">The new health of the entity</param>
    public void SetHealth(float newHealth)
    {

    }

    /// <summary>
    /// Used to add a certain amount of health (can be negative)
    /// </summary>
    /// <param name="addedHealth">The amount of health to be added (can be negative)</param>
    public void AddHealth(float addedHealth)
    {

    }

    /// <summary>
    /// Gets the stamina
    /// </summary>
    /// <returns>The stamina of the entity</returns>
    public float GetStamina()
    {
        return new float();
    }

    /// <summary>
    /// Sets the stamina of a entity
    /// </summary>
    /// <param name="newStamina">The new stamina of the entity</param>
    public void SetStamina(float newStamina)
    {

    }

    /// <summary>
    /// Used to add a certain amount of stamina (can be negative)
    /// </summary>
    /// <param name="addedStamina">The amount of stamina to be added (can be negative)</param>
    public void AddStamina(float addedStamina)
    {

    }

    /// <summary>
    /// For when the entity dies
    /// </summary>
    private void EntityDeath()
    {

    }

    /// <summary>
    /// This moves the character to a new location
    /// </summary>
    /// <param name="newPosition">The new place to place the character</param>
    private void Relocate(Vector2 newPosition)
    {

    }

    /// <summary>
    /// controls[0]: (X movement) (-1 left, 1 right)
    /// controls[1]: (Y movement) (-1 down, 1 up)
    /// controls[2]: (Sprint) (0 not sprinting, 1 sprinting)
    /// 
    /// Moves based on the inputs given
    /// 
    /// </summary>
    /// <param name="controls">The movement vector, [0]:x(-1,1), [1]:y(-1,1), [2]:spriting(0,1)</param>
    public void Move(float[] controls)
    {

    }

    /// <summary>
    /// Activates the skill 
    /// </summary>
    /// <param name="skillName">The name of the ability</param>
    public void ActivateSkill(string skillName)
    {

    }

    //May either use LookAt function or Rotate function, possibly we might use both. 

    /// <summary>
    /// Retates the character to look at a vector2 position
    /// </summary>
    /// <param name="LookLocation">The position you want the character to look at</param>
    public void LookAt(Vector2 LookLocation)
    {

    }

    /// <summary>
    /// Rotates the character by angles 
    /// </summary>
    /// <param name="rotationQuaternion">The angle</param>
    public void Rotate(Quaternion rotationQuaternion)
    {

    }

    /// <summary>
    /// Finds a skill on this character
    /// </summary>
    /// <param name="skillName">The name of the skill to look up</param>
    /// <returns></returns>
    public bool FindSkill(string skillName)
    {
        return new bool();
    }

    /// <summary>
    /// Calls FindSkill on newskill, add if it does exist
    /// </summary>
    /// <param name="newSkill">New skill!</param>
    /// <returns>true if added, false if rejected</returns>
    public bool AddSkill(Skill newSkill)
    {
        return new bool();
    }
}
