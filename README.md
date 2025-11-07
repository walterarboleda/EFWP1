## Creating an MVC Web App using Entity Framework
# By Walter Hugo Arboleda Mazo

<img width="1666" height="875" alt="image" src="https://github.com/user-attachments/assets/b9342235-5687-455e-95bf-d8072fa9c5ea" />

 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 Install-Package Microsoft.EntityFrameworkCore.Design
 Install-Package Microsoft.EntityFrameworkCore.Tools


Scaffold-DbContext 'Server=DESKTOP-GJDFMRJ\SQLEXPRESS01;Database=SampleDb;Trusted_Connection=True;TrustServerCertificate=True;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data -DataAnnotations -Force
