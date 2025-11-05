using SurfRater.Core.Data;
using SurfRater.Core.Data.Implementation.OpenMeteo;
using System.Text.Json;

namespace SurfRater.Core.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(50, 10, 60)]
    [DataRow(10, 10, 20)]
    public void TestarMetodoLegal(int num1, int num2, int resultadoExperado)
    {
        var instancia = new MinhaClasseLegal();
        var result = instancia.ObterSoma(num1, num2);

        Assert.AreEqual(resultadoExperado, result);
    }

    [TestMethod]
    public async Task RequisitionAsync()
    {
        var url = "https://marine-api.open-meteo.com/v1/marine?latitude=-28.491909619641834&longitude=-48.75918702201946&current=wave_height,wave_direction,wind_wave_direction&timezone=auto";

        using var httpClient = new HttpClient();

        try
        {
            var response = await httpClient.GetStringAsync(url);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var weatherData = JsonSerializer.Deserialize<MarineWeatherResponse>(response, options);

            if (weatherData?.Current == null)
            {
                Assert.Inconclusive("Sem dados marinhos disponíveis para esta coordenada.");
            }
            else
            {
                Assert.IsTrue(weatherData.Current.Wave_Height > 0, "Altura da onda deve ser maior que zero.");
            }
        }
        catch (HttpRequestException ex)
        {
            Assert.Inconclusive($"Erro na requisição: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Assert.Inconclusive($"Erro ao interpretar resposta da API: {ex.Message}");
        }
    }
}

//-28.491909619641834, -48.75918702201946