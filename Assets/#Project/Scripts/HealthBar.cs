using System;
using Unity.VisualScripting;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    [SerializeField] float maximumSize;
    [SerializeField] Health health;

    void Start()
    {
        // si current health == 0 -> scale 0
        // si current health == max -> scale maximumSize
        // si current health == max / 2 -> scale maximumSize / 2
        UpdateSize();
        health.onHealthChanged += UpdateSize;
    }

    void UpdateSize()
    {
        float t = (float) health.current / health.maximum;
        float scale = Mathf.Lerp(0, maximumSize, t);
        transform.localScale = new Vector3(scale, 1, 1);
    }

}
