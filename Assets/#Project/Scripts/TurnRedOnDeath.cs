using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Renderer))]
public class TurnRedOnDeath : DeathReaction
{
    [SerializeField] Color color;
    Renderer myRenderer;

    protected override void Start()
    {
        base.Start();
        myRenderer = GetComponent<Renderer>();
    }

    protected override void Effect()
    {
        myRenderer.material.color = color;
    }
}
