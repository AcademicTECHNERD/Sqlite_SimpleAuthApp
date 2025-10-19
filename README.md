# 🧩 LoginRegisterDemo

一个基于 **C# WinForms** 和 **SQLite** 的简易用户登录注册系统。  
该项目演示了用户注册、登录验证、数据库初始化等基本功能，适合初学者学习 WinForms + 数据库操作的整合。
这是一个非常简单的demo，方便初学winfrom者学习参考
---

## 🚀 功能特性
- 💾 自动初始化数据库表结构（首次运行自动创建）
- 第一次进入系统会默认创建一个用户：
                - 账户名：sa
                - 密码：123
- index首页
  ![index页面](https://github.com/user-attachments/assets/beafe0c5-ae7b-4767-a66c-1a80578f2d83)

- 登录成功进入主页
- ![成功进入系统](https://github.com/user-attachments/assets/8811b404-95e5-43c6-ac5d-87139c3e451f)

- 🧍 用户注册（支持用户名、密码、性别、邮箱）
![注册页面](https://github.com/user-attachments/assets/b0e473ce-e6ea-4032-b9e1-b27ee1b33ad5)

- 🔐 用户登录验证（本地 SQLite 数据库）
![登陆成功](https://github.com/user-attachments/assets/3ebd7a74-228f-4793-ac1e-77161e435c7c)

- 🧠 简洁的数据库操作封装（使用 `DatabaseHelper` 静态类）
- 🧰 支持扩展为完整的用户管理系统

---

## 🧱 技术栈

| 技术 | 说明 |
|------|------|
| C# (.NET Framework / .NET 6+) | 桌面程序开发 |
| WinForms | 图形界面 |
| SQLite | 本地数据库存储 |
| Microsoft.Data.Sqlite | 访问 SQLite 的官方库 |
| LINQ | 可选的内存查询扩展 |

---

## 📂 项目结构
![项目结构](https://github.com/user-attachments/assets/06029e3a-47d1-42b8-8a89-b0d704c9294c)


