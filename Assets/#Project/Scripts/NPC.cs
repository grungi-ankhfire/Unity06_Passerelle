using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{

    Greeter greeter = new();
    [SerializeField] Moods myMood;

    Moods[] allMoods = new Moods[] {Moods.Happy, Moods.Hungry, Moods.Sad, Moods.Tired, Moods.Angry};
    int moodIndex;

    [SerializeField] CharacterStats stats;

    [SerializeField] NPCProfile profile;


    void Start()
    {
        myMood = profile.mood;
        stats = profile.stats;
        moodIndex = Array.FindIndex(allMoods, elem => elem == myMood);
    }

    public void Interact()
    {
       Debug.Log(greeter[myMood]);
       if(moodIndex < allMoods.Length - 1)
        {
            moodIndex++;
            myMood = allMoods[moodIndex];
        }
    }
}
