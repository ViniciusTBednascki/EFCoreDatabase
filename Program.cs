using Database;

using (var db = new DataBaseContext())
{
  if(args.Length == 0)
  {
    Console.WriteLine("Description:\n  Database project using Entity Framework\n");
    Console.WriteLine("Usage:\n  dotnet run -- [options]\n");
    Console.WriteLine("Options:");
    Console.WriteLine(" create\t\t\t\t Create the template database");
    Console.WriteLine(" add <table> <values>\t\t Add a new value to table");
    Console.WriteLine(" update <table> <values>\t Update a value in table");
    Console.WriteLine(" delete <table> <values>\t Delete a value in table");
    return;
  }

  if(args[0] == "create")
  {
    Console.WriteLine("Creating template database...");
    db.Database.EnsureCreated();
  }
}