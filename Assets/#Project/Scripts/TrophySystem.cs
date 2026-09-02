using UnityEngine;

public class TrophySystem : MonoBehaviour
{
    bool unlocked;

    // Update is called once per frame
    void Update()
    {
        if (!unlocked && GameStats.totalDamage >= 50)
        {
            unlocked = true;
            Debug.Log("ACHIEVEMENT UNLOCKED : You got smacked around!");
        }        
    }
}
