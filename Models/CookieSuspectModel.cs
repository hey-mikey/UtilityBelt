using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityBelt.Models
{
  public class CookieSuspectModel
  {
    public List<CookieSuspect> results { get; set; }
  }
  public class CookieSuspect
  {
    public CookieSuspectName name { get; set; }
  }
  public class CookieSuspectName
  {
    public string first { get; set; }

    public string last { get; set; }
  }
}
