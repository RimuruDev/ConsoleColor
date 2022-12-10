# :pushpin:ConsoleColor
Output messages to the Unity console with different colors.

<p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/RimuruDev/ConsoleColor?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/ConsoleColor?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/ConsoleColor?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/ConsoleColor/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/ConsoleColor?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/ConsoleColor?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
</p>

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

