



 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 Install-Package Microsoft.EntityFrameworkCore.Design
 Install-Package Microsoft.EntityFrameworkCore.Tools


Scaffold-DbContext 'Server=DESKTOP-GJDFMRJ\SQLEXPRESS01;Database=SampleDb;Trusted_Connection=True;TrustServerCertificate=True;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data -DataAnnotations -Force
