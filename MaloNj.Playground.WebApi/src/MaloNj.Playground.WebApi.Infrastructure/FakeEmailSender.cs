﻿using MaloNj.Playground.WebApi.Core.Interfaces;

namespace MaloNj.Playground.WebApi.Infrastructure;

public class FakeEmailSender : IEmailSender
{
  public Task SendEmailAsync(string to, string from, string subject, string body)
  {
    return Task.CompletedTask;
  }
}
