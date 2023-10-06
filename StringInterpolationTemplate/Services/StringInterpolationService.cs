﻿using System;
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

    //  1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    //  2. 2019.01.22                   have to use _date throughout all methods
    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
    }

    //  3. Day 22 of January, 2019
    public string Number03()
    {
        var date = _date.Now;
        var answer = $"Day {date:dd} of {date:MMMM}, {date:yyyy}";
        Console.WriteLine(answer);

        return answer;
    }

    //  4.Year: 2019, Month: 01, Day: 22
    public string Number04()
    {
        var date = _date.Now;
        var answer = $"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}";
        Console.WriteLine(answer);

        return answer;
    }

    //  5.Tuesday (10 spaces total, right aligned)
    public string Number05()
    {
        var date = _date.Now.ToString("dddd");
        var answer = $"{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    //  6.      11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
    public string Number06()
    {
        var date = _date.Now;
        var answer = $"{date,10:t}{date,10:dddd}";
        Console.WriteLine(answer);

        return answer;
    }

    //7.    h:11, m:01, s:27
    public string Number07()
    {
        var date = _date.Now;
        var answer = $"h:{date:hh}, m:{date:mm}, s:{date:ss}";
        Console.WriteLine(answer);
        return answer;
    }

    //8.    2019.01.22.11.01.27
    public string Number08()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy}.{date:MM}.{date:dd}.{date:hh}.{date:mm}.{date:ss}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number09()
    {
        var date = _date.Now.ToString($"Day {"dd"} of {"Y"}");
        var answer = $"Day {date:dd} of {date:Y}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number10()
    {
        var date = _date.Now.ToString($"Day {"dd"} of {"Y"}");
        var answer = $"Day {date:dd} of {date:Y}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number11()
    {
        var date = _date.Now.ToString($"Day {"dd"} of {"Y"}");
        var answer = $"Day {date:dd} of {date:Y}";
        Console.WriteLine(answer);
        return answer;
    }

    
}
