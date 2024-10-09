using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : BarbieWorld<BarbieHouse>
{
    public void AddFurniture(string furniture)
    {
        AddItem(furniture);
        Debug.Log("Furniture added: " + furniture);
    }

    public void AddPet(string pet)
    {
        AddItem(pet);
        Debug.Log("Pet added: " + pet);
    }

    public void AddHouseholdItem(string item)
    {
        AddItem(item);
        Debug.Log("Household item added: " + item);
    }

}