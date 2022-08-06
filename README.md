#### By _**Zhibin Liang**_  

#### A facotry solution for managing engineers and machines

---
## Technologies Used

* C#
* HTML/CSS
* MySQL
* ASP.NET CORE

---
## Description

A user can manager the enginners and machines with full CRUD functionality. It also allow user to assign an engineer to a machine and modify this relationship from other side.

---
## Setup/Installation Requirements

<details>
<summary><strong>To Setup</strong></summary>

* Requires _MySQL_ for the database
* Install _Microsoft .NET SDK_
* Clone the repo
    ```
    $ git clone https://github.com/zbl14/Factory.Solution.git
    ```
</details>

<details>
<summary><strong>To Run</strong></summary>

* Navigate to  
   <pre>Factory.Solution
   ├── <strong>Factory</strong>
   └── Factory.Tests</pre>
* Create ```appsettings.json``` in the directory of _Factory_, and add following to the file with your MySQL username and password
    ```
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=zhibin_liang;uid=[username];pwd=[password];"
    }
    }
    ```
* Run follwing commands
    ```
    $ dotnet restore
    ```
    ```
    $ dotnet ef database update
    ```
    ```
    $ dotnet run
    ```
</details>

<details>
<summary><strong>For Testing</strong></summary>

* Navigate to  
    <pre>Factory.Solution
    ├── Factory
    └── <strong>Factory.Tests</strong></pre>

    ```
    $ dotnet restore
    ```
    ```
    $ dotnet test
    ```
</details>
<br/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* Cannot automatically update working status by assigning a machine to an engineer

## License
MIT

## Contact Information
Zhibin Liang <ifthereisoneday@gmail.com>

Copyright &copy; 2022 Zhibin Liang