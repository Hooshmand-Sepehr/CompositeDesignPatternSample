<h1>What is Composite Pattern?</h1>
<p>Composite pattern is used to separate abstraction from its implementation so that both can be modified independently.

Composite pattern is used when we need to treat a group of objects and a single object in the same way. Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchies.
This pattern creates a class contains a group of its own objects. This class provides ways to modify its group of the same objects.</p>
<br/>
<h2>UML class diagram</h2>


![image](https://user-images.githubusercontent.com/55051145/224473700-0cf095ea-7cbf-4632-90cb-c91a60d1acd5.png)


A visualization of the classes and objects participating in this pattern.

<br/>
<h2>Participants</h2>

<ul>
<li>
  Component
  <ul>
    <li>
      declares the interface for objects in the composition.
     </li>
     <li>
      implements default behavior for the interface common to all classes, as appropriate.
     </li>
     <li>
      declares an interface for accessing and managing its child components.
     </li>
     <li>
     (optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.
     </li>
  </ul>
  </li>
  <li>
  Leaf   
  <ul>
    <li>
      represents leaf objects in the composition. A leaf has no children.
     </li>
     <li>
     defines behavior for primitive objects in the composition.
     </li>

  </ul>
</li>

  <li>
  Composite      
  <ul>
    <li>
      defines behavior for components having children.
     </li>
     <li>
    stores child components.
     </li>
     <li>
     implements child-related operations in the Component interface.
     </li>

  </ul>
</li>

  <li>
  Client        
  <ul>
    <li>
     manipulates objects in the composition through the Component interface.
     </li>

  </ul>
</li>
</ul>

