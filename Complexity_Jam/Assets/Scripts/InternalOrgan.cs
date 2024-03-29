using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternalOrgan : Organ
{
    [SerializeField] SpriteRenderer myRenderer;
    [SerializeField] Material startMaterial;
    [SerializeField] Material blurredMaterial;
    [SerializeField] Color hiddenColor;
    [SerializeField] Color startColor;
    public override void Place()
    {
        //This is called when the organ is placed on a tile
        IsPlaced = true;
        myRenderer.material = blurredMaterial;
        myRenderer.color = hiddenColor;
    }

    public override void Remove()
    {
        //This is called when the organ is dragged by the player
        IsPlaced = false;
        myRenderer.material = startMaterial;
        myRenderer.color = startColor;
    }

    public override void Activate()
    {

    }
    public override void Deactivate()
    {

    }
}
