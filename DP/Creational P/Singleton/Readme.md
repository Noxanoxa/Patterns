# Design Patterns
## Creational Patterns
### Singleton Pattern

  **Description:** means that only create one instance of class

    - One instance used for all another classes for reduction the sizing memeory 
  **examples:** 
  1. calculate number of users in my sys with one instance of counter
  2. connection database used one time
  3. login or recording errors
  

  **Steps of Solution:**
  1. make constructor private to prevent instanction of the class
  2. add private instance of this class in the the same class 
  3. add public static method `GetInstance()` with return type is the same class and return the instance if the instance is not null else creating it  
  4. instead of creating instances by calling constructor we can use the method to use the only one instance 
