namespace AscendedHookHelper.Data;

public static class ReferenceData
{
    public const string RawGitHubAsaApiRepoUrl = "https://raw.githubusercontent.com/ServersHub/ServerAPI/main";
    public const string GitHubAsaApiHeadersFilePath = "/AsaApi/Core/Public/API/ARK";

    public const string SaveKey_HeaderDataPrefix = "header_data_";
    public const string SaveKey_HeaderStructDatasList = "header_struct_datas_list";
    public const string SaveKey_HeadersFunctionDatasList = "header_function_datas_list";
    public const string SaveKey_LastHeadersCachedDateTime = "last_headers_cached_datetime";

    public static readonly List<string> ArkHeaderNamesList = new List<string>()
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