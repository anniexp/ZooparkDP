# ZooparkDP
  Zoopark c# console application integrating three design patterns , one from each group
In this zoopark there are animals (which are created as objects with a factory), there are workers with given tasks to them(by a Chain of responsibility design patters).
 Every animal has a kind, region of habitat, type by what food it consumes, type by its biological structure(mammal, bird, etc), short description about given type and number of animals by kind. These are represented as properties of every animal object, created with the factory. The factory consists of a public interface IAnimal, classes which extend it, representing each kind of animal, living in the zoo and an Abstract Factory AnimalFactory. There is used  get method to get object of animal kind. With a switch statement, we choose from which kind do we create object with giving a key
 In each class the properties for each kind are being set.
 
 

