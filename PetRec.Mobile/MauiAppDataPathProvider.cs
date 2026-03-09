namespace PetRec.Mobile;

internal class MauiAppDataPathProvider : Core.Interfaces.IAppDataPathProvider
{
    public string GetDatabasePath() => Path.Combine(FileSystem.AppDataDirectory, "petrec.db");
}