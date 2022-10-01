// Обход папок

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}


string path = @"D:\!coding\!!!GeekBrains_course\projects\Cs\01_Hello_Lesson01\Example002_HelloUser";
CatalogInfo(path);
// string path = @"D:\!coding\!!!GeekBrains_course\projects\Cs\01_Hello_Lesson01\Example002_HelloUser";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// // Console.WriteLine(di.CreationTimeUtc);

// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }