using System;

namespace BlazorApp.Helpers
{
  public class DateHelper
  {
    public static string formatedDate()
    {
        DateTime date = DateTime.Now;
        return date.ToString("MMMM dd");
    }
  }
}