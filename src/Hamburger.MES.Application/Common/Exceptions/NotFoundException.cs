using System.Net;

namespace Hamburger.MES.Application.Common.Exceptions;

public class NotFoundException(string message) : AppException(message, (int)HttpStatusCode.NotFound);