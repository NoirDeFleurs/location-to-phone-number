using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.Services;

public partial class _Default : Page
{
protected void Page_Load(object sender, EventArgs e)
{
}

[System.Web.Services.WebMethod]
public static async Task<string> ObtenirInfosMobile(string code)
{
using (HttpClient client = new HttpClient())
{
try
{
string url = $"https://api.numlookupapi.com/v1/validate/{code}";
var response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
return responseBody;
}
catch (Exception ex)
{
return $"Erreur : {ex.Message}";
}
}
}
}
