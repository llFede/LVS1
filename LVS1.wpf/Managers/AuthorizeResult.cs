using LVS1.wpf.Models;

namespace LVS1.wpf.Managers;

public record AuthorizeResult(bool IsAuthorized, User? User = null);