using System;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] int gold;

    public void Interact()
    {
        Debug.Log($"You won {gold} gold pieces!");
    }
}
