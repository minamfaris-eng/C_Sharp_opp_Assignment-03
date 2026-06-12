//Q1: Identify the type of relationship
//a) A University has Departments. If the university is closed, the departments no longer exist.
//Relationship: Composition
//Reasoning: This is a strong "has-a" relationship with a strict lifecycle dependency.The parts (Departments) cannot exist independently of the whole (University).
//In C#, this is typically implemented by creating the Department objects directly inside the University class's constructor or as readonly fields initialized at creation.

//b) A Driver uses a Car. The driver does not own the car.
//Relationship: Dependency(or weak Association)
//Reasoning: The keyword "uses" strongly indicates a Dependency relationship. The Driver relies on the Car to perform an action,
//but does not manage its lifecycle or own it. In C#, this is often represented by passing the Car as a parameter to a method (e.g., Drive(Car car)),
//rather than storing it as a permanent field.

//c) A Dog is an Animal.
//Relationship: Inheritance
//Reasoning: This is a classic "is-a" relationship.In C#, this is implemented using the colon syntax: public class Dog : Animal.

//d) A Team has Players. If the team is deleted, the players still exist.
//Relationship: Aggregation
//Reasoning: This is a weak "has-a" relationship.The whole(Team) and the parts(Players) have independent lifecycles.
//If the Team object is destroyed, the Player objects can still exist and be assigned to other teams.
//In C#, this is usually implemented by passing existing Player objects into the Team (e.g., via a constructor or an AddPlayer method).

//e) A method receives a Logger as a parameter and calls it inside the method only.
//Relationship: Dependency
//Reasoning: This is the purest form of dependency.The class/ method has a temporary, localized reliance on the Logger to perform a specific task.
//The Logger is not stored as a class-level field; its scope is limited to the method execution.



//Q2: Access Modifiers and sealed in C#
//a) A parent class has a protected field.Can a child class in a different assembly access it? What about through an object instance from outside?
//Child class in a different assembly: Yes.The protected modifier allows access to the member within the class itself and in any class derived from it,regardless of the assembly it resides in.
//Through an object instance from outside: No. protected members cannot be accessed via an instance of the class from outside the class hierarchy.
//Even within a derived class, you can only access the protected member of the current instance (or an instance of the derived type), not an arbitrary instance of the base class.

//b) What is the difference between protected internal and private protected?
//protected internal: This is a union of protected and internal. The member is accessible to any code within the same assembly, OR to any derived class in any assembly.
//private protected: This is an intersection of private and protected. The member is accessible only to derived classes that are located within the same assembly.
//It is more restrictive than protected because it blocks derived classes in other assemblies from accessing it.

//c) What does the sealed keyword do when applied to a class? What about when applied to a method?
//Applied to a class: It prevents the class from being inherited. No other class can use a sealed class as a base class.
//Applied to a method: It prevents any further derived classes from overriding that specific method. 

//d) Can you create an object from a sealed class using new? Why or why not?
//Yes.
//Why: The sealed keyword only restricts inheritance. It does not restrict instantiation. A sealed class is a fully functional, normal class;
//it just cannot be used as a parent class. This is the opposite of an abstract class, which can be inherited but cannot be instantiated with new.
//Example: var myObj = new SealedClass(); .