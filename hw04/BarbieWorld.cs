using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
   
    //Answer:
    //GetComponent<T> is a method that allows us to get a component of a specified type from a game object.(for example, a rigidbody, a collider, etc.)
    //This allows me to specify the type of the component at call time without having to do a type conversion inside the function. 
    //Instead of T, I can specify the type of the component I want to get. So it is really flexible and can be used for any type of component.
    //This is why it is considered a generic method.

    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
    //Answer:
    //We would use the letter T to represent that.
    //If there are more than one parameter, we would use T1, T2, T3, etc. to represent the different types.
    //To make it more readable, we can also use more descriptive names like TKey, TValue, TElement, etc.

    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
    //Answer:
    //The generic variable allows us to specify the type of the variable at call time. This makes the code more flexible and reusable.(like some time we want to use a list of integers, sometimes we want to use a list of strings)
    //When we can define the return type and argument type as the generic type, we can use the same method for different types of variables. This makes the code more reusable and flexible.

    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
    //When I want to create a list that can store different types of objects. Like an inventory system that can store different types of items.
    //I can use a generic list to store the items. This way, I can store different types of items in the same list.
    //To be more specific, there are lots of different items in the game, like weapons, coins, props,etc. I can classify them into different classes and use a generic list to store them.
    //(I am not sure if this is a good example, do there are any other examples? XD)

    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
    //Answer:
    //Because the generic arrays are type-safe, they are slower than non-generic arrays.

    * What does it mean to instantiate? */
    //Answer:
    //Instantiate means to create an instance of a class or object. It is used to create a new object of a class.
    //generics are used to create classes, methods, and interfaces that can work with any data type.
public class BarbieWorld<T>
{
    T item;
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
    //Answer:
    //The function below is trying to set the current career of Barbie to a new career.

    How are we using the T variable in this case?
    //Answer:
    //We are using the T variable to specify the type of the new career. This makes the code more flexible and reusable.

    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */

    T currentCareer;
    protected void BarbieCareers(T newCareer)
    {
        currentCareer = newCareer;
    }

    protected List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
        Debug.Log("Item added: " + item);
    }

    public void RemoveItem(string item)
    {
        items.Remove(item);
        Debug.Log("Item removed: " + item);
    }

    public void ListItems()
    {
        Debug.Log("Items in BarbieWorld:");
        foreach (var item in items)
        {
            Debug.Log(item);
        }
    }
}