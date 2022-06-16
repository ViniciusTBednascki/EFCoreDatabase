using Database;

using (var db = new DataBaseContext())
{
  Console.WriteLine("Garantido que o banco de dados esteja criado...");
  db.Database.EnsureCreated();
}