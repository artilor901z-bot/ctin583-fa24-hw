using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public enum CollectibleItems
{
    Bomb,
    Rock,
    Gem,
    Leaf,
    Flower,
    Fake,
    Enemy,
    Player,
}



public interface CollectibleInterface {
    void myCollectable(CollectibleItems items);
}

//Problem 1 Answer
//By using the interface, we can create a handler class that will handle the collection of items.
//And By using switch case, we can easily identify the item that is collected.
public class CollectibleHandler : CollectibleInterface
{
    public void myCollectable(CollectibleItems items)
    {
        switch (items)
        {
            case CollectibleItems.Bomb:
                Debug.Log("Bomb");
                break;
            case CollectibleItems.Rock:
                Debug.Log("Rock");
                break;
            case CollectibleItems.Gem:
                Debug.Log("Gem");
                break;
            case CollectibleItems.Leaf:
                Debug.Log("Leaf");
                break;
            case CollectibleItems.Flower:
                Debug.Log("Flower");
                break;
            case CollectibleItems.Fake:
                Debug.Log("Fake item");
                break;
            case CollectibleItems.Enemy:
                Debug.Log("Enemy");
                break;
            case CollectibleItems.Player:
                Debug.Log("Player");
                break;
            default:
                Debug.Log("Unknown Item");
                break;
        }
    }

    //Problem 2 Answer
    //I create a enum with the name of CollectibleItems and add all the items that can be collected.
    public void myCollectableWithOutString(CollectibleItems items)
    {
        CollectibleItems collectedItem;

        switch (items)
        {
            case CollectibleItems.Bomb:
                collectedItem = CollectibleItems.Bomb;
                break;
            case CollectibleItems.Rock:
                collectedItem = CollectibleItems.Rock;
                break;
            case CollectibleItems.Gem:
                collectedItem = CollectibleItems.Gem;
                break;
            case CollectibleItems.Leaf:
                collectedItem = CollectibleItems.Leaf;
                break;
            case CollectibleItems.Flower:
                collectedItem = CollectibleItems.Flower;
                break;
            case CollectibleItems.Fake:
                collectedItem = CollectibleItems.Fake;
                break;
            case CollectibleItems.Enemy:
                collectedItem = CollectibleItems.Enemy;
                break;
            case CollectibleItems.Player:
                collectedItem = CollectibleItems.Player;
                break;
            default:
                Debug.Log("Unknown item collected");
                return;
        }

        HandleCollectible(collectedItem);
    }

    private void HandleCollectible(CollectibleItems item)
    {
        Debug.Log($"Collected a {item.ToString()}");
    }


    private void Start()
    {
        //Problem 3 Answer
        //Tuple Example

        //Normal Tuple
        Tuple<string, int, int> player = new Tuple<string, int, int>("Justin", 178, 90);
        Debug.Log($"Player Name: {player.Item1}, Height: {player.Item2}, Weight: {player.Item3}");
        //Value Tuple
        (string, int, int) score = ("Justin", 178, 90);
        Debug.Log($"Player Name: {player.Item1}, Height: {player.Item2}, Weight: {player.Item3}");
        //I would use tuple when I want to return multiple values from a method.

        //PS: I still feel unclear with the tuple, I hope I can learn more about it.
    }

    public void PlayParticles()
    {
 
        ParticleTypes particleType = ParticleTypes.FireParticles;
        Debug.Log($"Playing {particleType.ToString()} particles");
    }

}

//Problem 4 Answer
public enum ParticleTypes
{
    FireParticles,
    GoldRibbons,
    Snowflakes,
    RainParticles,
    IMGDParticles,
}
