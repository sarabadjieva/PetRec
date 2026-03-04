namespace PetRec.Mobile;

internal class MauiAppDataPathProvider : PetRec.Application.IAppDataPathProvider
{
    public string GetDatabasePath() => Path.Combine(FileSystem.AppDataDirectory, "petrec.db");
}