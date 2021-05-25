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
  
    ===============================Classes & Objects===============================
 
    In object -oriented programming, a class defines some properties, fields, events, methods, etc.
    Object is an entity that has state and behavior. Here, state means data and behavior means functionality.
  
    ===============================Access Modifier===============================
  
    Access Modifiers in C# are the keywords used to define the visibility of a class property or method.
	  C# has 5 Access Modifier keywords
	   1. public: Public class is visible in the current and referencing assembly.
	   2. private: Visible inside current class.
	   3. protected: Visible inside current and derived class.
	   4. Internal: Visible inside containing assembly.
	   5. Internal protected: Visible inside containing assembly and descendent of thecurrent class.
  
    ===================================Method====================================
  
    Method are also called function. 
    Method are useful because it allow us to define our logic once and use it at many places.
  
    Syntax:
      accessModifier returnType methodName(parameters)
      {
        //Method Body
      }
  
    ===============================Constructor================================
  
    A constructor is a special type of Method with no return type. 
    A constructor is called automatically when we create an object of a class. 
	  *Method that Same Name of Class Name 
	  *Don't have return type, so don't return values 
	  *Access modifier can be used 
	  *No need to call constructor, It invoked when objects get created 
	  *It initialize member variables of a Class 
	  *you can declare more than one constructor in a class 
	  *Constructor can be Overloaded
        
    ===============================Inheritance==============================
  
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
      1. Single Inheritance > Only One Parent class and Child Class
      2. Multilevel > 
      3. Hierarchical > One parent class bt more than child class 
      4. Multiple > Not Possible
      5. Hybrid > Not Possible
          //Single Inheritance  //Multilevel          //Hierarchical
          Class A               Class A               Class A
           {                     {                      {  
           }                     }                      } 
          Class B:A             Class B:A              Class B:A 
            {                    {                      {  
            }                    }                      }  
                                Class C:B               Class B:A  
                                 {                        {
                                 }                        }
    
       
    ===============================Polymorphism===============================
    
    Polymorphism provides the ability to a class to have multiple implementation with the same name
		
	     1. Static/Compile Time - (Method Overloading)     
	     2. Dynamic/Runtime - (Method Overriding)
	     
	     * Method Overriding Can be done by usign Inheritance
	     * With method overriding, we can override the method of ParentClass with same method of ChildClass
     
     #Conditions For Method Overriding:
        1.All Method Name should same           
        2.All the method should be in different class
        3.Method should have same Parameters    
        4.There should be Inheritance between Class
        
    ==================================Interfaces=============================== 
  
    Interface is look like a class but it has no implementation, they simply declaration.
     *It cann't have Method Body. 
     *We cann't create an instance of an Interface
     *Class can inherite Multiple interface at the same time
     *Interfaces can inherite from others Interfaces
     
     Restrictions:
        1.Not allowed to define any fields,not even static fields
        2.Not allowed to define any constructor/desturctor in interafce
        3.Cann't specify any access Modifier, implicitly public
        4.Not allowed to inherite from a  class/structure
    
     ================================Abstraction======================================
     
     Data abstraction is the process of hiding certain details and showing only essential information to the user.
     Abstraction can be achieved with either abstract classes or interfaces.

     * An abstract class is a special class we can't be instantiated.
     * An abstract keyword is used to create abstract classes.
     * We can use an abstract class as a base class only.
     
     Abstract Method:
     * An abstract method is a method without any method body. 
     * can only be used in an abstract class
     
     Contents:
        1. An abstract class may contains abstract members,property,event
        2. An abstract class can only be a base class
        3. A non-abstract class can inherite from an abstract class but must provide implementation
        4. If the class doesn't wish implementation,then the class has to be marked as abstract.
        5. To provide the implementation, have to use the override keyword.
        6. An abstract class cann't be sealed.
        7. Cann't create an object.
        8. Abstract class cann't support multiple inheritances
        9. An abstract class can inherit from a class and one or more interfaces.  

        
