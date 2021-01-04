using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    [Tooltip("How far the npc can see")]
    public float VisionDistance;

    [Tooltip("The degrees an npc can see")]
    public float VisionDegree;

    [Tooltip("The amount of rays per degree")]
    public int RaysPerDegree;
}
