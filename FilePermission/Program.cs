using System;

FileSystem fs = new FileSystem();

Console.WriteLine("=== 파일 권한 관리 ===\n");

Console.WriteLine($"현재 권한: {fs.GetCurrentFlag()}\n");

Console.WriteLine("[권한 추가]");
fs.AddFlag(File.FilePermission.Read);
Console.WriteLine($"+ Read 추가: {fs.GetCurrentFlag()}");
fs.AddFlag(File.FilePermission.Write);
Console.WriteLine($"+ Write 추가: {fs.GetCurrentFlag()}");
fs.AddFlag(File.FilePermission.Execute);
Console.WriteLine($"+ Execute 추가: {fs.GetCurrentFlag()}");

Console.WriteLine("\n[권한 확인]");
Console.WriteLine($"Read 권한: {fs.HasFlag(File.FilePermission.Read)}");
Console.WriteLine($"Write 권한: {fs.HasFlag(File.FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {fs.HasFlag(File.FilePermission.Execute)}");

Console.WriteLine("\n[권한 제거]");
fs.DeleteFlag(File.FilePermission.Write);
Console.WriteLine($"Write 제거: {fs.GetCurrentFlag()}");

Console.WriteLine("\n[제거 후 확인]");
Console.WriteLine($"Read 권한: {fs.HasFlag(File.FilePermission.Read)}");
Console.WriteLine($"Write 권한: {fs.HasFlag(File.FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {fs.HasFlag(File.FilePermission.Execute)}");
