using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank : MonoBehaviour
{

    // Start is called before the first frame update

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */

    //answer:
    void Start()
    {
        //question 2
        BarbieWorld<string> barbiehat = new BarbieWorld<string>();

        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);

        //Testing: BarbieBank
        int[] barbiebank=G_BarbieBank<int>(100, 200, 300);
    }

    private int[] BarbieWallet(int money1, int money2)
    {
        return new int[] { money1, money2 };
    }
    private void GetMoney(int money1, int money2)
    {
        Debug.Log(money1 + " " + money2);
    }

    // BarbieBank Generic Function  
    private T[] G_BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards)
    {
        return new T[] { numOfPennies, cashAmount, numOfCreditCards };
    }


    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
        
        //Answer:
        //Protected access modifier allows the child class to access the member variables and member functions of the parent class.
        //For example, public class A and public class B: A. If the member variables and member functions of class A are protected, class B can access them.

        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
        
        //Answer:
        //Monobehaviour is a class that inherits from the Unity engine. It is the base class for all Unity scripts.
        //For example, Start(), Update(), Awake(), etc. are the functions that come from MonoBehaviour.(using unity)

        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
        //Answer:
        //multiple inheritance is a feature of object-oriented programming that allows a class to inherit from more than one class.
        //By searching on google, I found that C# does not support multiple inheritance. This is because it can cause ambiguity and other problems.
        //Because of that, C#uses interfaces to achieve the same functionality as multiple inheritance.(I would like to know more about that during the lecture)
        
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
        //Answer:
        //Protected virtual void means that the function can be overridden by the child class. It is needed when we want to allow the child class to override.
        //Therefore, we can rewrite the function in the child class. The virtual keyword allows the function to be overridden by the child class.

        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
        //Answer:
        //When a constructor in a parent class is called, the child class constructor is also called. This is because the child class inherits the constructor from the parent class.
        //We can contorl it by ¡°base".
     */
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}