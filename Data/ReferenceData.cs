namespace AscendedHookHelper.Data;

public static class ReferenceData
{
    public const string RawGitHubAsaApiRepoUrl = "https://raw.githubusercontent.com/ServersHub/ServerAPI/main";
    public const string GitHubAsaApiHeadersFilePath = "/AsaApi/Core/Public/API/ARK";

    public static List<string> ArkHeaderNamesList = new List<string>()
    {
        "Actor",
        "GameMode",
        "Inventory",
        "PrimalStructure",
        "Buff",
        "UE",
        "Other"
    };
}