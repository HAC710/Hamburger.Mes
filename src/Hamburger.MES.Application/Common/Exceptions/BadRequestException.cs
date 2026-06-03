using System.Net;

namespace Hamburger.MES.Application.Common.Exceptions;

public class BadRequestException(string message) : AppException(message, (int)HttpStatusCode.BadRequest);