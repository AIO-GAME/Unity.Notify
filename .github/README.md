<p align="center"> 
<img src="RES/Logo.svg" width="256" height="256" alt="https://github.com/AIO-GAME"> 
</p>
<p align="center" style="font-size: 24px;"> 
<b>Unity Notify</b>
</p>
<p align="center"><a href="README_EN.md">English</a> | 简体中文</p>
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

## ⚙ 安装

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

> open upm *中国版*

~~~
Name: package.openupm.cn
URL: https://package.openupm.cn
Scope(s): com.aio.notify
~~~

> open upm *国际版*

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

## ⭐ 关于

- **Unity Notify** 是一个轻量级的事件通知系统，支持事件订阅、广播和取消订阅。
- ✅ **支持** 事件类实现。
- ✅ **支持** 事件参数传递。
- ✅ **支持** 事件参数泛型。
- ✅ **支持** 事件优先级。
- ✅ **支持** 事件订阅。
- ✅ **支持** 事件取消订阅。
- ✅ **支持** 事件广播执行基于协程，不阻塞主线程。
- ✅ **支持** 事件自动注册。
- ✅ **支持** 事件自动取消注册。
- ✅ **支持** 事件自动广播。
- ✅ **支持** 事件自动优先级。

## 📚 使用

<h4>初始化</h4>

```csharp 
EventSystem.Initialize();
``` 

<h4>注册事件</h4>

```csharp
AddListener.AddListener(eid, OnEvent);
AddListener.AddListener<[T1~T9]>(eid, OnEvent);
``` 

<h4>广播事件</h4>

```csharp
AddListener.Broadcast(eid);
AddListener.Broadcast(eid, [T1~T9]);
```  

<h4>注销事件</h4>

```csharp
AddListener.RemoveListener(eid, OnEvent);
AddListener.RemoveListener<[T1~T9]>(eid, OnEvent);
AddListener.RemoveListener(eid);
```  

<h4>自动注册事件</h4>

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

## ✨ 贡献者

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
            <td align="center">
                <a href="https://github.com/Starkappa">
                    <img src="https://avatars.githubusercontent.com/u/155533864?v=4" width="64;" alt="Starkappa"/>
                    <br />
                    <sub><b>Starkappa</b></sub>
                </a>
            </td>
		</tr>
	<tbody>
</table>
<!-- readme: collaborators,contributors -end -->

## 📢 致谢

- **谢谢您选择我们的扩展包。**
- **如果此软件包对您有所帮助。**
- **请考虑通过添加⭐来表示支持。**