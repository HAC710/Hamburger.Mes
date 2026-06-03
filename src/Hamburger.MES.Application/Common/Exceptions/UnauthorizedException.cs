using System.Net;

namespace Hamburger.MES.Application.Common.Exceptions;

public class UnauthorizedException(string message = "Unauthorized.")
    : AppException(message, (int)HttpStatusCode.Unauthorized);