using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        throw new NotImplementedException();
    }

    public string Number03()
    {
        throw new NotImplementedException();
    }

    public string Number04()
    {
        throw new NotImplementedException();
    }

    public string Number05()
    {
        throw new NotImplementedException();
    }

    public string Number06()
    {
        throw new NotImplementedException();
    }

    public string Number07()
    {
        throw new NotImplementedException();
    }

    public string Number08()
    {
        throw new NotImplementedException();
    }

    public string Number09()
    {
        throw new NotImplementedException();
    }

    public string Number10()
    {
        throw new NotImplementedException();
    }

    //2.2019.01.22
}
