using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{

    [Tooltip("The name of the skill")]
    public string Name;

    /// <summary>
    /// When using or creating anything that needs to be saved use this, do not create another variable because it might lost D=
    /// </summary>
    [Tooltip("Data for the skill")]
    public Dictionary<string, float> Data;

    /// <summary>
    /// This determines which character the skill occurs on.
    /// </summary>
    private Character CharacterToActivateOn;

    /// <summary>
    /// Updates the character to activate on 
    /// </summary>
    /// <param name="newCharacter">The new character</param>
    public void ChangeCharacterToActivateOn(Character newCharacter)
    {
    }

    /// <summary>
    /// Activates this skill
    /// </summary>
    /// <returns>True if success, false if falure</returns>
    public virtual bool Activate()
    {
        return new bool();
    }


}
