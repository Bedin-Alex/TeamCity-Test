var target = Argument("target", "first");

Task("first")
.Does(() => 
{
   Information("This action runs first.");
});

Task("second")
.IsDependentOn("first")
.ContinueOnError()
.WithCriteria(DateTime.Now.Second  < 1)
.Does(() => 
{
    if (DateTime.Now.Second % 2 == 0)
    {
        Information("Cond. = Ok");
    }
        Information("This action runs Second.");
});

Task("get files")
.IsDependentOn("second")
.DoesForEach(GetFiles("./*/*"), file =>
{
    Information("File = " +file+ " with size = "+ FileSize(file)+" B");
});

Task("Path")
.IsDependentOn("get files")
.Does(() =>
{
    Information("Test");
    var path = Context.Environment.WorkingDirectory + "/tool";
    foreach (var file in GetFiles($"{path}/*"))
    {
        Information($"file = ${file}");
    }
}
);

RunTarget(target);