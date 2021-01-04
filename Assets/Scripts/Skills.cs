using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{

    public List<Skill> skillList;

    
    /// <summary>
    /// This is so you can call basically do a list of skills and can call Skills[0] to get the first skill
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public Skill this[int key]
    {
        get => skillList[key];
    }

    /// <summary>
    /// Returns the amount of skills in list
    /// </summary>
    /// <returns>The amount of skills in the skillList</returns>
    public int Length()
    {
        return new int();
    }

    /// <summary>
    /// Find skill with the name 
    /// </summary>
    /// <param name="skillName"></param>
    /// <returns></returns>
    public Skill FindSkill(string skillName)
    {
        return new Skill();
    }

    /// <summary>
    /// Add a new skill
    /// </summary>
    /// <param name="newSkill">A skill!</param>
    /// <returns>True if sucessfully added, false otherwise</returns>
    public bool AddSkill(Skill newSkill)
    {
        return new bool();
    }

    /// <summary>
    /// Remove skill based on skill name
    /// </summary>
    /// <param name="skillName">The name of the skill</param>
    /// <returns>True if sucessful, false otherwise</returns>
    public bool RemoveSkill(string skillName)
    {
        return new bool();
    }

    /// <summary>
    /// Removes a skill based on skill object
    /// </summary>
    /// <param name="skillToRemove">The skill object to remove</param>
    /// <returns>True if sucessful, false otherwise</returns>
    public bool RemoveSkill(Skill skillToRemove)
    {
        return new bool();
    }
}
