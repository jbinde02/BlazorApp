using System;

namespace BlazorApp.Helpers
{
  public class DateHelper
  {
        /**
         * Format dates, apparently.
         * Testing.
         */
    public static string formatedDate()
    {
        DateTime date = DateTime.Now;
        return date.ToString("MMMM dd");
    }
  }
}