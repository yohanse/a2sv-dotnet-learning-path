﻿using DotNetConf._2022Edition.Core.Interfaces;

namespace DotNetConf._2022Edition.Infrastructure;

public class FakeEmailSender : IEmailSender
{
  public Task SendEmailAsync(string to, string from, string subject, string body)
  {
    return Task.CompletedTask;
  }
}
