# Refused Bequest

Refer to [Refused Bequest](https://refactoring.guru/smells/refused-bequest) on the site [Refactoring Guru](https://refactoring.guru).


The problem can be solved either via [Replace Inheritance with Delegation](https://refactoring.guru/replace-inheritance-with-delegation) or [Extract Superclass](https://refactoring.guru/extract-superclass).

## Replace Inheritance with Delegation

```csharp
class Chair
{
    public string Leg1{ get; set; }        
    public string Leg2{ get; set; }        
    public string Leg3{ get; set; }        
    public string Leg4{ get; set; }

    public void Sit()
    {
        Console.WriteLine("Sit on " + Leg1 + Leg2 + Leg3 + Leg4);
    }
}

class Dog : Chair
{
    public void Bark()
    {
        Console.WriteLine("Bark on " + Leg3 + Leg4);
         // it doesn't use Chair.Sit().
        // It's the sign it shoudln't inherit from Chair
    }
}
```

* Select the 4 fields and run `Extract Class` calling the new class `Legs`
* Manually, inject `Legs` in `Dog` too

## Extract Superclass

* Select `Chair` and run `Extract Superclass`, calling the new class `WithLegs` and selecting the fields to move up.
* Alternatevely, just create the new class and move up the fields later. Select one of the fields and run `Pull member up`. From the dialog it's possible to add the other fields as well.
* Manually, let `Dog` inherit from `WithLegs` rather than from `Chair`