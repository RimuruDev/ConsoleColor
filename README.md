# :pushpin:ConsoleColor
Output messages to the Unity console with different colors.

# How to start
Move the unitypackage or Scripts folder to unity.

## Don't forget NameSpace 
I recommend replacing the namespace with your own.
```csharp
using RimuruDev;
```
# How to use?
The Console.Log() method has 2 reloads. The first one takes 2 parameters: The message to output to the console and the color. The second overload accepts a message for output to the console and is red by default.
```csharp
 Console.Log("Miss", ColorType.Yellow);
```
![изображение](https://user-images.githubusercontent.com/85500556/206851285-d02c0fe9-6c14-4a13-b07a-98b12352c2ea.png)

```csharp
 Console.Log("Miss");   
```
![изображение](https://user-images.githubusercontent.com/85500556/206851303-b7887947-7d7b-4e0a-a1da-ec10f86bed3b.png)

