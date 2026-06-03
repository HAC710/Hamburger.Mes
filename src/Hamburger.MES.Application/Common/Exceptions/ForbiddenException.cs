using System.Net;

namespace Hamburger.MES.Application.Common.Exceptions;

public class ForbiddenException(string message = "Forbidden.") : AppException(message, (int)HttpStatusCode.Forbidden);