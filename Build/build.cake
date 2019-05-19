var target = Argument("target", "Default");
var src = Argument("source","../PersianFaker.sln");

Task("Build")
  .Does(() =>
{
    DotNetCoreBuild(src);
});

Task("Clean")
    .Does(() =>
{
    DotNetCoreClean(src);
});

Task("Restore")
    .Does(() =>
{
    DotNetCoreRestore(src);
});
Task("Test")
    .Does(() =>
{
    var projectFiles = GetFiles("../**/*.Tests.csproj");
    foreach(var file in projectFiles)
    {
        DotNetCoreTest(file.FullPath);
    }
});
Task("Default")
.IsDependentOn("Clean")
.IsDependentOn("Restore")
.IsDependentOn("Build")
.IsDependentOn("Test");
RunTarget(target);