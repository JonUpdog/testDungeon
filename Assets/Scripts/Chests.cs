using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : Collectable
{
    public Sprite emptyChest;
    public int frogAmount = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.frogs += frogAmount;
            GameManager.instance.ShowText($"+ {frogAmount} frogs!", 25, Color.green, transform.position, Vector3.up * 50, 1.0f);
        }
    }
}
