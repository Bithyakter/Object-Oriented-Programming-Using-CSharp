# Object Oriented Programming Using CSharp

Learn Object Oriented Programming(OOP) Using C# with Examples

OOP Topics Cover:
  1. Classes & Objects
  2. Method & Constructor
  3. Encapsulation
  4. Inheritance
  5. Polymorphism
  6. Interfaces
  7. Access Modifier
  
 ===========================================Classes & Objects===========================================
  In object -oriented programming, a class defines some properties, fields, events, methods, etc.
  Object is an entity that has state and behavior. Here, state means data and behavior means functionality.
  
  ===========================================Access Modifier===========================================
  
  Access Modifiers in C# are the keywords used to define the visibility of a class property or method.
  C# has 5 Access Modifier keywords
   1. public: Public class is visible in the current and referencing assembly.
   2. private: Visible inside current class.
   3. protected: Visible inside current and derived class.
   4. Internal: Visible inside containing assembly.
   5. Internal protected: Visible inside containing assembly and descendent of thecurrent class.
  
  
  ===============================================Method================================================
  
  Method are also called function. Method are useful because it allow us to define our logic once and use it at many places.
    Syntax:
      accessModifier returnType methodName(parameters)
      {
        //Method Body
      }
  
  ===========================================Constructor============================================
  A constructor is a special type of Method with no return type. A constructor is called automatically when we create an object of a class. 
  * Method that Same Name of Class Name 
  * Don't have return type, so don't return values 
  * Access modifier can be used 
  * No need to call constructor, It invoked when objects get created 
  * It initialize member variables of a Class 
  * you can declare more than one constructor in a class 
  * Constructor can be Overloaded
        
    ===========================================Inheritance===========================================
    
    Inheritance is a process of inheriting the properties and behaviour of existing class into New class.
     
    SYNTAX :
        class <Parent Class>
            {
                //variables or Method
            }
        class <child class>:<parent class>
            {
                ///variables or Method
            }
 
       Method Hiding:
            *  Use the 'new' keyword to hide a base class members.
            *  Also you can use the 'base' keyword to call the hidden base class members.
       
    ===========================================Polymorphism===========================================
    
    Polymorphism provides the ability to a class to have multiple implementation with the same name
     
     1. Static/Compile Time - (Method Overloading)     
     2. Dynamic/Runtime - (Method Overriding)
     * Method Overriding Canbe done by usign Inheritance
     * With method overriding, we can override the method of ParentClass with same method of ChildClass
     
     #Conditions For Method Overriding:
        1.All Method Name should same           
        2.All the method should be in different class
        3.Method should have same Parameters    
        4.There should be Inheritance between Class
        
    ===========================================Interfaces=========================================== 
    Interface is look like a class but it has no implementation, they simply declaration.
     * It cann't have Method Body. 
     * We cann't create an instance of an Interface
     * Class can inherite Multiple interface at the same time
     * Interfaces can inherite from others Interfaces
     Restrictions:
        1.Not allowed to define any fields,not even static fields
        2.Not allowed to define any constructor/desturctor in interafce
        3.Cann't specify any access Modifier, implicitly public
        4.Not allowed to inherite from a  class/structure
    
        
        
