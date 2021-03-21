using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
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

    [Tooltip("Explore distance, the distance the npc will go to explore")]
    public float ExploreDistance;


    [Tooltip("How often the npc will return to the default location")]
    public float ResetPercentage;

    [Tooltip("How often the npc will move around a location")]
    public float WanderPercentage;

    [Tooltip("Controls Vision")]
    public Vision NPCVision;

    private NavMeshAgent agent;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        StartCoroutine(Action(5));

    }

    private IEnumerator Action(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            
            if (ShouldExplore())
            {

                Debug.Log("Exploring");
                GoToRandomLocation(ExploreLocation, new Vector2(ExploreDistance, ExploreDistance));
            } else
            {
                Debug.Log("Going to default location");
                GoToLocation(DefaultLocation);
            }

            if (ShouldChangeWanderPosition())
            {
                Debug.Log("Changing wandering position");
                GoToRandomLocation(ExploreLocation, new Vector2(WanderDistance, WanderDistance));
            }
        }



    }

    private bool GoToRandomLocation(Vector2 location, Vector2 distance)
    {
        return GoToLocation(new Vector2(Random.Range(-distance.x, distance.x) + location.x, Random.Range(-distance.y, distance.y) + location.y));
    }

    private bool GoToRandomLocation(Vector2 distance)
    {
        return GoToLocation(new Vector2(Random.Range(-distance.x, distance.x), Random.Range(-distance.y, distance.y)));
    }

    /// <summary>
    /// Goes to the new location
    /// </summary>
    /// <param name="newLocation">NewLocation</param>
    public bool GoToLocation(Vector2 newLocation)
    {

        ExploreLocation = newLocation;

        NavMeshPath path = new NavMeshPath();

        if (agent.CalculatePath(newLocation, path))
        {

            agent.SetPath(path);

            return true;
        }


        return false;
    }

    /// <summary>
    /// Checks to see if it should change its wander position
    /// </summary>
    /// <returns>Returns true if it should, otherwise false</returns>
    private bool ShouldChangeWanderPosition()
    {
        if (Random.Range(0f,1f) < WanderPercentage)
        {
            return true;
        }

        return false;
    }
    
    /// <summary>
    /// Checks to see if it should explore
    /// </summary>
    /// <returns>Return true if it should explore, false otherwise</returns>
    private bool ShouldExplore()
    {

        if (Random.Range(0f,1f) < ExplorePercentage)
        {
            return true;
        }

        return false;
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
