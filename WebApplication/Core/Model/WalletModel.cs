using System;

namespace WebApplication.Authentication
{
  public class WalletModel
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int Amount { get; set; }
    public int Currency { get; set; }
  }
}