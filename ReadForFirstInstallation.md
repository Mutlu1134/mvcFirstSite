# MVC proje oluşturmak için yapılması gerekenler

1.  VSCode kurulur.
2.  .Net SDK kurulur.
3.  nuget.org'tan (nuget packages) "Microsoft.AspNetCore.Mvc.Razor.ViewCompilation" kurulumu için .NET CLI kodu vscode terminalden çalıştırılır.
4.  Proje oluşturmak için bir klasör açıldıktan sonra terminale "dotnet new mvc" yazılarak proje oluşturulur.
5.  Terminale "dotnet run" yazarsak, terminalde yazan localhost/PORTNUMBER üzerinden sitemiz çalışmış olur.
6.  Controller'daki değişikliklerde "dotnet run"ı kapat aç yapmak gerekir. Ama view'deki değişiklikleri anlık görebilmek için 3.adımdaki işlemi yapmıştık. İndirilen razor runtine compilation'u başarılı olduğunu anlamak için;
7.  projeismi.csproj dosyası içinde aşağıdaki şekilde bir satır eklenmesi gerekli
    `<ItemGroup> <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.ViewCompilation" Version="2.2.0" /> </ItemGroup>`
8.  Program.cs dosyasına aşağıdaki kodları ekle . (.net 6 için geçerli. .NET5'te startup.cs dosyasına yazılıyormuş)
    `var builder = WebApplication.CreateBuilder(args); builder.Services.AddRazorPages() .AddRazorRuntimeCompilation();`
9.  Bu aşamadan sonra View'larda değişiklik yapıldığında sayfayı yenilemek yeterli. :)

10. Shared->\_Layout üzerinde parçalama düzenleme yaparken. Örneğin \_layout'un Head kısmını kesiyoruz. \_Head.cshtml oluşturup oraya kaydediyoruz. \_Layout.cshtml'de kestiğimiz yere kestiğimiz kodu çağırmak için `@{await Html.RenderPartialAsync("_Head");}` yazıyoruz.

11. Bu şekilde \_Header \_Footer \_Script vs.yi parçalıyoruz ki kolay yönetebilelim.
12. Body içinde değişken yere ise `@RenderBody()` yazıyoruz.
