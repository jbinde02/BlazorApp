using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BlazorApp.Data
{
  public class APIcaller
  {
    public static void APIcall(){
      string URL = "https://disease.sh/v3/covid-19/states";
      string URLparameters = "";
      HttpClient client = new HttpClient();
      client.BaseAddress = new Uri(URL);

      // Add an Accept header for JSON format.
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

      //List data response
      HttpResponseMessage response = client.GetAsync(URLparameters).Result;
      if(response.IsSuccessStatusCode){
        string dataObjects = response.Content.ReadAsStringAsync().Result;
        Console.Write(dataObjects);
      }
      else
      {
        Console.Write("failure");
      }
      client.Dispose();
    }
  }
}