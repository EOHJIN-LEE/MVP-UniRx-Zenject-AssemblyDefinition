# MVP + UniRx + Zenject + AssemblyDefinition

## Purpose of the template
Create a neat game structure using MVP pattern.

## Why do you use the MVP pattern?
![image](https://user-images.githubusercontent.com/44941601/163097139-92655787-c3bb-491f-8cb5-11ce1d3bb3fd.png)

This pattern allows you to separate "pure data"(Model) from "business logic"(Presenter) and "reusable components"(View)

However, there is a problem that the complexity of the presenter increases as the function increases.
So, by creating "WrapperView", which wraps "View", "Presenter" has been improved to focus more on business logic.

## Why do you use UniRx?
"The presenters" can code in a format that responds to "Model" and "WrapperView", So the "UniRx" makes the code more neat.

## Why do you use Zenject?
This is because the dependence of MVP patterns can be controlled in one place through DI.

## Why do you use AssemblyDefinition?
It prevents programmers from making spaghetti codes outside the MVP pattern and improves compilation speed.
