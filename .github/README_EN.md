<p align="center"> 
<img src="RES/Logo.svg" width="256" height="256" alt="https://github.com/AIO-GAME"> 
</p>
<p align="center" style="font-size: 24px;"> 
<b>Unity Notify</b>
</p>
<p align="center"><a href="README_EN.md">简体中文</a> | English</p>
<p align="center">
<a href="https://github.com/AIO-GAME/Unity.Notify/security/policy"> 
<img alt="" src="https://img.shields.io/github/package-json/unity/AIO-GAME/Unity.Notify"> 
</a>
<a href="https://github.com/AIO-Game/Unity.Notify">
<img src="https://img.shields.io/github/license/AIO-Game/Unity.Notify" alt=""/>
</a>
<a href="https://github.com/AIO-Game/Unity.Notify">
<img src="https://img.shields.io/github/languages/code-size/AIO-Game/Unity.Notify?label=size" alt=""/>
</a>
<a href="https://openupm.com/packages/com.aio.notify/">
<img src="https://img.shields.io/npm/v/com.aio.notify?label=openupm&amp;registry_uri=https://package.openupm.com" alt=""/>
</a>
</p>

## ⚙ Install

<details>
<summary>
<span style="color: deepskyblue; "><b>Packages Manifest</b></span>
</summary>

````json
{
  "dependencies": {
    "com.aio.notify": "latest"
  },
  "scopedRegistries": [
    {
      "name": "package.openupm.com",
      "url": "https://package.openupm.com",
      "scopes": [
        "com.aio.notify"
      ]
    }
  ]
}
````

</details>

<details>
<summary>
<span style="color: deepskyblue; "><b>Unity PackageManager</b></span>
</summary>

> open upm *Chinese Version*

~~~
Name: package.openupm.cn
URL: https://package.openupm.cn
Scope(s): com.aio.notify
~~~

> open upm *International Version*

~~~
Name: package.openupm.com
URL: https://package.openupm.com
Scope(s): com.aio.notify
~~~

</details>

<details>
<summary>
<span style="color: deepskyblue; "><b>Command Line</b></span>
</summary>

> open *upm-cli*

~~~
openupm add com.aio.notify
~~~

</details>

## ⭐ About

- **Unity Notify** is a lightweight event notification system that supports event subscription, broadcasting, and unsubscription.
- ✅ **Support** event class implementation.
- ✅ **Support** event parameter passing.
- ✅ **Support** event parameter generics.
- ✅ **Support** event priority.
- ✅ **Support** event subscription.
- ✅ **Support** event unsubscription.
- ✅ **Support** event broadcast execution based on coroutine, not blocking the main thread.
- ✅ **Support** event automatic registration.
- ✅ **Support** event automatic unRegistration.
- ✅ **Support** event automatic broadcast.
- ✅ **Support** event automatic priority.

## 📚 Usage

<h4>Initialize</h4>

```csharp 
EventSystem.Initialize();
``` 

<h4>Subscribe event</h4>

```csharp
AddListener.AddListener(eid, OnEvent);
AddListener.AddListener<[T1~T9]>(eid, OnEvent);
``` 

<h4>Broadcast event</h4>

```csharp
AddListener.Broadcast(eid);
AddListener.Broadcast(eid, [T1~T9]);
```  

<h4>Unsubscribe event</h4>

```csharp
AddListener.RemoveListener(eid, OnEvent);
AddListener.RemoveListener<[T1~T9]>(eid, OnEvent);
AddListener.RemoveListener(eid);
```  

<h4>Auto Register Event</h4>

```csharp
public class EventListener1 : EventHandler
{
    public override int Key { get; } => 0;
    
    protected override void Invoke() => Console.WriteLine("OnEvent");
}

public class EventListener2 : EventHandler<[T1~T9]>
{
    public override int Key { get; } => 0;
    
    protected override void Invoke(<[T1~T9]> args) => Console.WriteLine("OnEvent");
}

``` 

## ✨ Contributors

<!-- readme: collaborators,contributors -start -->
<table>
	<tbody>
		<tr>
            <td align="center">
                <a href="https://github.com/xinansky">
                    <img src="https://avatars.githubusercontent.com/u/45371089?v=4" width="64;" alt="xinansky"/>
                    <br />
                    <sub><b>xinansky</b></sub>
                </a>
            </td>
		</tr>
	<tbody>
</table>
<!-- readme: collaborators,contributors -end -->

## 📢 Thanks

- **If this package is helpful to you.**
- **Please consider adding a ⭐ to show your support.**
- **It will be a great encouragement for me to continue to improve.**