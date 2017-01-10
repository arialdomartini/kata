# Refactoring Type Code with State/Strategy

Refer to [Replace Type Code with State/Strategy](https://refactoring.guru/replace-type-code-with-state-strategy) on the site [Refactoring Guru](https://refactoring.guru).

The idea is to separate the logic for Manager, Salesmane and Engineer to 3 dedicated classes, all implementing the same abstract class `EmpooyeeType`. The code in `Employee` will continue using the numeric `Type` field, but this will delegate to a typed Employee type.


I'm not aware of a way to refactor this with ReSharper. Apparently, only manual operations must be performed.

* Using `Encapsulate field` with `Read usages` and `Write usages` introduce the property `EmployeeType`
* Change the type of `EmployeeType` to `EmployeeType`. Adjust the property `Type` accordingly
  * Create the new class `EmployeeType` and make it abstract.
  * Rename `Type` it to `EmployeeTypeCode`
  * `EmployeeTypeCode`'s getter should return `EmployeeType.Code`
  * `EmployeeTypeCode`'s setter should rely on a `EmployeeType` static Factory method, where a **switch case** will return one of the respective classes `Manager`, `Salesman` and `Engineer`
  * Create each of them
  * Move `Code` to them, making it abstract in `EmployeeType`
* Now the `PayAmount` can delegate to an abstract `PayAmount` on `EmployeeType`. Each `PayAmount` can be implemented in `Manager`, `Salesman` and `Engineer`.