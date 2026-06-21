using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using MealsApp.Classes;

namespace MealsApp
{
	internal static class ImageService
	{
		static HttpClient httpClient = new HttpClient();

		public static async Task<Image> LoadThumbs(string url, CancellationToken ct)
		{
			try
			{
				ct.ThrowIfCancellationRequested();

				var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);

				response.EnsureSuccessStatusCode();

				using (var netStream = await response.Content.ReadAsStreamAsync())

				using (var ms = new MemoryStream())
				{
					ct.ThrowIfCancellationRequested();

					await netStream.CopyToAsync(ms);

					ct.ThrowIfCancellationRequested();

					ms.Position = 0;

					return await Task.Run(() => Image.FromStream(ms), ct);
				}
			}
			catch (OperationCanceledException)
			{

			}
			catch (Exception ex)
			{
				App.ErrorsLoggingService.Log(ex.ToString());
			}
			 
			return Properties.Resources.no_photos;
		}

		public static async Task<Image> LoadIngredientsThumbs(string url, CancellationToken ct)
		{
			try
			{
				ct.ThrowIfCancellationRequested();

				var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);

				response.EnsureSuccessStatusCode();

				using (var netStream = await response.Content.ReadAsStreamAsync())

				using (var ms = new MemoryStream())
				{
					ct.ThrowIfCancellationRequested();

					await netStream.CopyToAsync(ms);

					ct.ThrowIfCancellationRequested();

					ms.Position = 0;

					return await Task.Run(() => Image.FromStream(ms), ct);
				}
			}
			catch (OperationCanceledException)
			{
				App.ErrorsLoggingService.Log("Ingredients thumbs have canceled");
			}
			catch (Exception ex)
			{
				App.ErrorsLoggingService.Log(ex.ToString());
			}

			return Properties.Resources.no_photos;
		}

	}


}
