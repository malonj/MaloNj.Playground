namespace MaloNj.Playground.WebApi.Web.ViewModels;

public class ErrorViewModel
{
  public string? RequestId { get; set; }

  public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
