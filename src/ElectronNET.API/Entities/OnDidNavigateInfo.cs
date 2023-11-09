namespace ElectronNET.API.Entities;

/// <summary>
/// 'DidNavigate' event details.
/// </summary>
public class OnDidNavigateInfo
{
    /// <summary>
    /// Navigated URL.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// HTTP response code.
    /// </summary>
    public int HttpResponseCode { get; set; }
}
