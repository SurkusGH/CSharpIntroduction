using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conventions
{
    // Class Names should be PascalCase
    AbstractAnimal animal;

    // local Variables,Field names should be camelCase
    int age;
    int firstName;

    // constants also PascalCase and NOT Screaming Caps (LOCATIONID)
    public const string LocationId = "BERLIN";

    // Always use meaningful names for variables. Avoid single letters (except in for-loops)
    int t;
    bool c;
    // This is much easier to read
    int timer;
    bool timerCompleted;

    // Don't use abbreviations! Id, Xml and similar are alright
    Person prsn;
    Person person;

    // Don't use underscores
    Animal black_panther;
    // Only use them on private class fields
    private Animal _lion;

    // Use Nouns for class names
    Animal newAnimal;
    Person anotherPerson;

    // prefix Interfaces with the letter I
    IFlyable flyable;

    // Use singular names for enums. Never use Enum inside the Name!
    GameDifficulty difficulty;
    enum Color { Red, Green, Blue } // Instead of Colors

    // https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
}
